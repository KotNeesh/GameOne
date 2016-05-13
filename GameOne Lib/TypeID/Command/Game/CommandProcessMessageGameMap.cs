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
    Обрабатывает сообщения, пришедшие из интернета.
    </summary>
    */
    class CommandProcessMessageGameMap : ICommandProcessMessage
    {
        byte ITypeID.Type
        {
            get
            {
                return (TypeID)HelperTypeID.GameMap;
            }
        }

        void ICommandProcessMessage.Do(IParameters parameters, IMessage message)
        {
            IParametersSceneGameMessages p = parameters as IParametersSceneGameMessages;
            p.GetSceneGameMessages().SetMessage((MessageGameMap)message);
        }
    }
}
