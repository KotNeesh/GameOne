using SimpleTeam.GameOneID.Scene;
using System;

namespace SimpleTeam.GameOneID.Command
{
    using SimpleTeam.Command.Scenario;
    using TypeID = Byte;
    public class ParametersSceneMenu : IParametersSceneMenu
    {
        public TypeID Type
        {
            get
            {
                return (TypeID)HelperParameterID.SceneMenu;
            }
        }

        ISceneMenu _scene;
        public ParametersSceneMenu(ISceneMenu scene)
        {
            _scene = scene;
        }
        public ISceneMenu GetSceneMenu()
        {
            return _scene;
        }

        public IScenario GetScenario()
        {
            return _scene.GetScenario();
        }
    }
}