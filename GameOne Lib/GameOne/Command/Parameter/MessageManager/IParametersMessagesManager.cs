using SimpleTeam.Command;
using SimpleTeam.Message.Manager;

namespace SimpleTeam.GameOneID.Command
{
    public interface IParametersMessagesManager : IParameters
    {
        IMessagesManagerScenario GetMessagesManager();
    }
}
