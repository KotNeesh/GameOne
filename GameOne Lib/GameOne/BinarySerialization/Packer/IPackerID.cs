using System;
using SimpleTeam.Message;

using System.IO;

namespace SimpleTeam.GameOneID.BinarySerialization
{
    using SizePacket = UInt16;
    public interface IPackerID : ITypeID
    {
        void CreatePacket(BinaryWriter writer, IMessage message);
    }
}
