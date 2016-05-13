using System;
using SimpleTeam.Message;

namespace SimpleTeam.GameOneID.Message
{
    using TypeID = Byte;

    [Serializable]
    public sealed class MessageGamerCommand : MessageBase
    {
        public override TypeID Type
        {
            get
            {
                return (TypeID)HelperTypeID.GamerCommand;
            }

        }
    }
}