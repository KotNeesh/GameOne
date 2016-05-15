using UnityEngine;
using SimpleTeam.Network;
using SimpleTeam.GameOne.Scene;
using SimpleTeam.GameOne.Message.Manager;
using SimpleTeam.Command.Scenario;
using SimpleTeam.Command;
using SimpleTeam.GameOne.Command;

namespace SimpleTeam.Main
{
    public class Client : MonoBehaviour
    {
        public SceneClientMenu SceneMenu;
        public SceneClientGame SceneGame;
        MessagesManager _messagesManager;
        NetworkClientMachine _network;
        ScenarioMachine _scenario;

        public void Start()
        {
            _messagesManager = new MessagesManager();
            _network = new NetworkClientMachine(_messagesManager);
            IAllParameters p = new AllGameOneParameters(SceneMenu, SceneGame, _messagesManager);
            _scenario = new ScenarioMachine(p);
            _network.Start();
            _scenario.Start();
        }
        public void OnGUI()
        {
        }



        public void OnDestroy()
        {
            if (_network != null) _network.Close();
            if (_scenario != null) _scenario.Close();
        }
    }
}

