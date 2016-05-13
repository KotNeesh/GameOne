using System;
using SimpleTeam.Message;
using SimpleTeam.Network;
using System.IO;
using SimpleTeam.BinarySerialization;

namespace SimpleTeam.GameOneID.BinarySerialization
{
    using SizePacket = UInt16;

    public interface IUnpackerID : ITypeID
    {
        UnpackerState CreateMessage(ref IMessage message, BinaryReader reader, SizePacket size);
    }
}
