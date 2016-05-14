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
    class CommandProcessMessageGameMap : CommandProcessMessageAdapterSceneGame
    {
        public override TypeID Type
        {
            get
            {
                return (TypeID)HelperMessageID.GameMap;
            }
        }
        protected override void DoMy(IParametersSceneGame parameters, IMessage message)
        {
            parameters.GetSceneGame().SetMessage((MessageGameMap)message);
        }
    }
}
