using SimpleTeam.GameOneID.Scene;
using System;

namespace SimpleTeam.GameOneID.Command
{
    using SimpleTeam.Command.Scenario;
    using TypeID = Byte;
    public class ParametersSceneGame : IParametersSceneGame
    {
        public TypeID Type
        {
            get
            {
                return (TypeID)HelperParameterID.SceneGame;
            }
        }
        ISceneGame _scene;
        public ParametersSceneGame(ISceneGame scene)
        {
            _scene = scene;
        }
        public ISceneGame GetSceneGame()
        {
            return _scene;
        }

        public IScenario GetScenario()
        {
            return _scene.GetScenario();
        }
    }
}
