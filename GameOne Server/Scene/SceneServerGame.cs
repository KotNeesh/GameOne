﻿

using System;
using SimpleTeam.Command;
using SimpleTeam.GameOneID.Message;
using SimpleTeam.Command.Scenario;

namespace SimpleTeam.Scene
{
    class SceneServerGame : ISceneGameMessages
    {
        //ISceneScenario
        private SceneScenario _sceneScenario = new SceneScenario();

        public IScenario GetScenario()
        {
            return ((ISceneScenario)_sceneScenario).GetScenario();
        }


        //ISceneGameMessages
        void ISceneGameMessages.SetMessage(MessageGamerCommand message)
        {
            throw new NotImplementedException();
        }

        void ISceneGameMessages.SetMessage(MessageGameState message)
        {
            throw new NotImplementedException();
        }

        void ISceneGameMessages.SetMessage(MessageGameMap message)
        {
            throw new NotImplementedException();
        }
    }
}
