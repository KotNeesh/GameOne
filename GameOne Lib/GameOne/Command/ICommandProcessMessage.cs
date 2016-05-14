using SimpleTeam.Command;
using SimpleTeam.Message;
using System;

namespace SimpleTeam.GameOneID.Command
{
    using TypeID = Byte;
    public interface ICommandProcessMessage : ITypeID
    {
        void Do(IParameters parameters, IMessage message);
        TypeID GetParameterType();
    }
}
