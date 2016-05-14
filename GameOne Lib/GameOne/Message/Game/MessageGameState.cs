using System;
using SimpleTeam.Message;

namespace SimpleTeam.GameOneID.Message
{
    using TypeID = Byte;

    [Serializable]
    public sealed class MessageGameState : MessageBase
    {
        public override TypeID Type
        {
            get
            {
                return (TypeID)HelperMessageID.GameState;
            }
        }
    }
}