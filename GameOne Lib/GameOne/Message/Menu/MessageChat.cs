using System;
using SimpleTeam.Message;

namespace SimpleTeam.GameOneID.Message
{
    using TypeID = Byte;

    [Serializable]
    public sealed class MessageChat : MessageBase
    {
        public override TypeID Type
        {
            get
            {
                return (TypeID)HelperMessageID.Chat;
            }
        }

        public string Line;
        public MessageChat(String line)
        {
            Line = line;
        }
    };
}