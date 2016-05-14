using SimpleTeam.GameOne.Scene;
using SimpleTeam.Command.Scenario;
using System.Collections.Generic;
using SimpleTeam.Message.Manager;
using SimpleTeam.Command;
using System;

namespace SimpleTeam.GameOne.Command
{
    /**
    <summary> 
    Хранит все необходимые параметры для исполнения команд.
    </summary>
    */
    public class AllGameOneParameters : AllParameters
    {
        public AllGameOneParameters(ISceneMenu sceneMenu, ISceneGame sceneGame, IMessagesManager messagesManager) : base()
        {
            _parameter.Add(new ParameterSceneMenu(sceneMenu));
            _parameter.Add(new ParameterSceneGame(sceneGame));
            _parameter.Add(new ParameterMessagesManager(messagesManager));
        }


    }
}
