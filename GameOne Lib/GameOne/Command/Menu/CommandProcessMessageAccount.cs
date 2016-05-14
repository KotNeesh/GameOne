using System;
using SimpleTeam.Message;
using SimpleTeam.GameOneID.Message;

namespace SimpleTeam.GameOneID.Command
{
    using TypeID = Byte;
    /**
    <summary> 
    Обрабатывает сообщения аккаунта, пришедшие из интернета.
    </summary>
    */
    class CommandProcessMessageAccount : CommandProcessMessageAdapterSceneMenu
    {
        public override TypeID Type
        {
            get
            {
                return (TypeID)HelperMessageID.Account;
            }
        }
        protected override void DoMy(IParametersSceneMenu parameters, IMessage message)
        {
            parameters.GetSceneMenu().SetMessage((MessageAccount)message);
        }
    }
}
