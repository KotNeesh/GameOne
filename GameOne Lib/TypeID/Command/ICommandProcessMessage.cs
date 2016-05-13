using SimpleTeam.Command;
using SimpleTeam.Message;

namespace SimpleTeam.GameOneID.Command
{
    public interface ICommandProcessMessage : ITypeID
    {
        void Do(IParameters parameters, IMessage message);
    }
}
