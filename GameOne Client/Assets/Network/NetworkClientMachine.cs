﻿using System;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using SimpleTeam.SystemBase;
using SimpleTeam.User;
using SimpleTeam.Message;
using SimpleTeam.GameOne.Message.Manager;
using SimpleTeam.BinarySerialization;
using SimpleTeam.BinarySerialization.DotNet;
using SimpleTeam.Network;

namespace SimpleTeam.GameOne.Network
{
    /**
    <summary> 
    Получает сообщения от сервера и складывает их в менеджер сообщений.
    <para/>
    Получает сообщения из менеджера сообщений и отправляет их серверу.
    </summary>
    */
    sealed class NetworkClientMachine : StateMachine
    {
        bool _isConnected;
        IUserNetwork _server;
        IPAddress _ip;
        private IMessagesManagerNetwork _messagesManager;

        private NetworkUserProtocol _network = new NetworkUserProtocol();

        private IUnpacker _unpacker = new Unpacker();
        private IPacker _packer = new Packer();

        public NetworkClientMachine(IMessagesManagerNetwork messagesManager)
        {
            _isConnected = false;
            _ip = IPAddress.Parse("127.0.0.1");
            _server = new UserNetwork();
            _server.Socket.SendBufferSize = 1024;
            _server.Socket.ReceiveBufferSize = 1024;
            _messagesManager = messagesManager;
        }

        protected override bool Init()
        {
            
            return true;
        }
        protected override void Deinit()
        {
            _server.Socket.Close();
        }
        protected override bool DoAnything()
        {
            Thread.Sleep(100);
            CheckConnection();
            SendAll();
            ReceiveAll();
            return true;
        }
        private void CheckConnection()
        {
            if (!_server.Socket.Connected)
            {
                try
                {
                    if (_isConnected)
                    {
                        _server.Socket.Close();
                        _server.Socket = new TcpClient();
                        _server.Socket.SendBufferSize = 1024;
                        _server.Socket.ReceiveBufferSize = 1024;
                    }
                    _isConnected = true;
                    _server.Socket.Connect(_ip, 30);
                }
                catch (SocketException ex)
                {
                    Console.WriteLine("Exception: " + ex.ToString());
                    _isConnected = false;
                }
            }
        }
        private void SendAll()
        {
            while (true)
            {
                IMessage m = _messagesManager.GetMessage();
                if (m == null) break;
                Packet p = null;
                _packer.CreatePacket(ref p, m);
                _server.PacketsSend.Enqueue(p);
            }
            _network.Send(_server);
        }
        private void ReceiveAll()
        {
            while (true)
            {
                _network.Receive(_server);
                IMessage m = null;
                UnpackerState s =  _unpacker.CreateMessage(ref m, _server.PacketReceive);
                if (s == UnpackerState.Ok)
                {
                    _messagesManager.SetMessage(m);
                    _server.PacketReceive.Clear();
                }
                else if (s == UnpackerState.NotReady) return;
                else
                {
                    throw new System.SystemException("hoho");
                }
            }
        }
        public IUserNetwork GetUser()
        {
            return _server;
        }
    }
}

