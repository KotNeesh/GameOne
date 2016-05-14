using SimpleTeam.Command.Scenario;

namespace SimpleTeam.GameOneID.Scene
{
    public class SceneScenario : ISceneScenario
    {
        protected IScenario _scenario;
        public SceneScenario()
        {
            _scenario = new ScenarioQueue();
        }
        public IScenario GetScenario()
        {
            return _scenario;
        }
    }
}
