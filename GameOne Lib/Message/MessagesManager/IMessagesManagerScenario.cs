using SimpleTeam.Command.Scenario;

namespace SimpleTeam.Message.Manager
{
    /**
    <summary> 
    Переферия для внутренних сообщеий.
    </summary>
    */
    public interface IMessagesManagerScenario
    {
        void SetMessage(IMessage message);
        IScenario GetScenario();
    }
}
