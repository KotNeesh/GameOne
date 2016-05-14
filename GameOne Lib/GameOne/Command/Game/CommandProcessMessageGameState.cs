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
    class CommandProcessMessageGameState : CommandProcessMessageAdapterSceneGame
    {
        public override TypeID Type
        {
            get
            {
                return (TypeID)HelperMessageID.GameState;
            }
        }
        protected override void DoMy(IParametersSceneGame parameters, IMessage message)
        {
            parameters.GetSceneGame().SetMessage((MessageGameState)message);
        }
    }
}