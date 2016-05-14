using SimpleTeam.GameOneID.Scene;
using SimpleTeam.Command.Scenario;
using System.Collections.Generic;
using SimpleTeam.Message.Manager;
using SimpleTeam.Command;
using System;

namespace SimpleTeam.GameOneID.Command
{
    /**
    <summary> 
    Хранит все необходимые параметры для исполнения команд.
    </summary>
    */
    public class AllParametersMy : AllParameters
    {
        public AllParametersMy(ISceneMenu sceneMenu, ISceneGame sceneGame, IMessagesManager messagesManager) : base()
        {
            _parameters.Add(new ParametersSceneMenu(sceneMenu));
            _parameters.Add(new ParametersSceneGame(sceneGame));
            _parameters.Add(new ParametersMessagesManager(messagesManager));
        }


    }
}
