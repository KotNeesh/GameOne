using SimpleTeam.GameOneID.Message;

namespace SimpleTeam.Scene
{
    public interface ISceneGameMessages : ISceneScenario
    {
        void SetMessage(MessageGameMap message);
        void SetMessage(MessageGameState message);
        void SetMessage(MessageGamerCommand message);
    }
}
