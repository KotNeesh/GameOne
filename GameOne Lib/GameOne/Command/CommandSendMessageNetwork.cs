using SimpleTeam.Message;
using SimpleTeam.Command;
using System;

namespace SimpleTeam.GameOneID.Command
{
    
    using TypeID = Byte;
    /**
    <summary>
    Команда для отправки сообщения в интернет.
    </summary>
    */
    public class CommandSendMessageNetwork : ICommand
    {
        public TypeID Type
        {
            get
            {
                return (TypeID)HelperParameterID.MessageManager;
            }
        }

        IMessage _message;
        public CommandSendMessageNetwork(IMessage message)
        {
            _message = message;
        }

        void ICommand.Do(IAllParameters parameters)
        {
            IParametersMessagesManager p = parameters as IParametersMessagesManager;
            p.GetMessagesManager().SetMessage(_message);
        }
    }
}
