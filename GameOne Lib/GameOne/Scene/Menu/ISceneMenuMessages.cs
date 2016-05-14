using SimpleTeam.GameOneID.Message;

namespace SimpleTeam.GameOneID.Scene
{
    /**
    <summary>
    Интерфейс обработки сообщений меню сценой
    </summary>
    */
    public interface ISceneMenuMessages
    {
        void SetMessage(MessageChat message);
        void SetMessage(MessageAccount message);
        void SetMessage(MessageProfile message);
    }
}
