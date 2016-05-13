using System;
using SimpleTeam.Command;
using SimpleTeam.Message;
using SimpleTeam.GameOneID.Message;
using SimpleTeam.Command.Scenario;

namespace SimpleTeam.GameOneID.Command
{
    using TypeID = Byte;
    /**
    <summary> 
    Обрабатывает сообщения чата, пришедшие из интернета.
    </summary>
    */
    class CommandProcessMessageChat : ICommandProcessMessage
    {
        byte ITypeID.Type
        {
            get
            {
                return (TypeID)HelperTypeID.Chat;
            }
        }

        void ICommandProcessMessage.Do(IParameters parameters, IMessage message)
        {
            IParametersSceneMenuMessages p = parameters as IParametersSceneMenuMessages;
            p.GetSceneMenuMessages().SetMessage((MessageChat)message);
        }
    }
}
