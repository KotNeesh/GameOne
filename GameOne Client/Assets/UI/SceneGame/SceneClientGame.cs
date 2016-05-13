﻿using UnityEngine;
using SimpleTeam.Command;
using SimpleTeam.Message;
using System;
using SimpleTeam.Command.Scenario;
using SimpleTeam.GameOneID.Message;

namespace SimpleTeam.Scene
{
    public class SceneClientGame : MonoBehaviour, ISceneGameMessages
    {
        //ISceneScenario
        private SceneScenario _sceneScenario = new SceneScenario();

        public IScenario GetScenario()
        {
            return ((ISceneScenario)_sceneScenario).GetScenario();
        }


        //ISceneMenuMessages

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
