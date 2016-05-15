﻿using UnityEngine;
using SimpleTeam.Network;
using SimpleTeam.GameOne.Scene;
using SimpleTeam.GameOne.Message.Manager;
using SimpleTeam.Command.Scenario;
using SimpleTeam.Command;
using SimpleTeam.GameOne.Command;

namespace SimpleTeam.Main
{
    public class Client : MonoBehaviour, IMain
    {
        public SceneClientMenu SceneMenu;
        public SceneClientGame SceneGame;
        private MessagesManager _messagesManager;
        private NetworkClientMachine _network;
        private ScenarioMachine _scenario;
        private bool _isExit;
        public void Start()
        {
            _isExit = false;
            _messagesManager = new MessagesManager();
            _network = new NetworkClientMachine(_messagesManager);
            IAllParameters p = new AllGameOneParameters(this, SceneMenu, SceneGame, _messagesManager);
            _scenario = new ScenarioMachine(p);
            _network.Start();
            _scenario.Start();
        }
        public void OnGUI()
        {
        }
        public void Update()
        {
            if (_isExit)
            {
                Application.Quit();
            }
        }


        public void OnDestroy()
        {
            if (_network != null) _network.Close();
            if (_scenario != null) _scenario.Close();
        }

        public void Exit()
        {
            _isExit = true;
        }
    }
}

