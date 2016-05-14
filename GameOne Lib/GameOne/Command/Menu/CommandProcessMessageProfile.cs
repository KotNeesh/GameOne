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
    Обрабатывает сообщения игрового профиля, пришедшие из интернета.
    </summary>
    */
    class CommandProcessMessageProfile : CommandProcessMessageAdapterSceneMenu
    {
        public override TypeID Type
        {
            get
            {
                return (TypeID)HelperMessageID.Profile;
            }
        }
        protected override void DoMy(IParametersSceneMenu parameters, IMessage message)
        {
            parameters.GetSceneMenu().SetMessage((MessageProfile)message);
        }
    }
}
