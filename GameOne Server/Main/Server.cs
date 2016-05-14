using System.Threading;
using SimpleTeam.Network;
using SimpleTeam.SystemBase;
using SimpleTeam.GameOneID.Command.Scenario;
using SimpleTeam.Command;
using SimpleTeam.GameOneID.Command;
using SimpleTeam.Message.Manager;
using SimpleTeam.GameOneID.Scene;

namespace SimpleTeam.Main
{
    /**
    <summary> 
    Управление сервером.
    </summary>
    */
    sealed class Server
    {
        MessagesManager _messagesManager;
        SceneServerMenu _sceneMenu;
        SceneServerGame _sceneGame;
        NetworkServerMachine _network;
        ScenarioMachine _scenario;
        ConsoleCtrl cc;
        public Server()
        {
            _sceneMenu = new SceneServerMenu();
            _sceneGame = new SceneServerGame();
            _messagesManager = new MessagesManager();
            _network = new NetworkServerMachine(_messagesManager);
            cc = new ConsoleCtrl();
            IAllParameters p = new AllParametersMy(_sceneMenu, _sceneGame, _messagesManager);
            _scenario = new ScenarioMachine(p);
        }
        public void Start()
        {
            cc.ControlEvent += new ConsoleCtrl.ControlEventHandler(this.Close);
            Go();
        }
        private void Close(ConsoleCtrl.ConsoleEvent consoleEvent)
        {
            if (consoleEvent == ConsoleCtrl.ConsoleEvent.CtrlClose)
            {
                _network.Stop();
                _scenario.Stop();
                _network.Close();
                _scenario.Close();
                _network = null;
                System.Environment.Exit(-1);
            }
        }

        private void Go()
        {
            _network.Start();
            _scenario.Start();
            while (true)
            {
                Thread.Sleep(int.MaxValue);
            }
        }
    }
}

