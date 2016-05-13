using SimpleTeam.Message;
using SimpleTeam.Command.Scenario;

namespace SimpleTeam.Command
{
    /**
    <summary>
    Команда для отправки сообщения в интернет.
    </summary>
    */
    public class CommandSendMessageNetwork : ICommand
    {
        IMessage _message;
        public CommandSendMessageNetwork(IMessage message)
        {
            _message = message;
        }

        void ICommand.Do(IParameters parameters)
        {
            IParametersMessagesManagerScenario p = parameters as IParametersMessagesManagerScenario;
            p.GetMessagesManagerScenario().SetMessage(_message);
        }
    }
}
