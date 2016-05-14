using SimpleTeam.GameOneID.Message;

namespace SimpleTeam.GameOneID.Scene
{
    public interface ISceneGameMessages
    {
        void SetMessage(MessageGameMap message);
        void SetMessage(MessageGameState message);
        void SetMessage(MessageGamerCommand message);
    }
}
