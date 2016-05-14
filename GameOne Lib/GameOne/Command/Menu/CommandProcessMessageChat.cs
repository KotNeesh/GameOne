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
    class CommandProcessMessageChat : CommandProcessMessageAdapterSceneMenu
    {
        public override TypeID Type
        {
            get
            {
                return (TypeID)HelperMessageID.Chat;
            }
        }
        protected override void DoMy(IParametersSceneMenu parameters, IMessage message)
        {
            parameters.GetSceneMenu().SetMessage((MessageChat)message);
        }
    }
}
