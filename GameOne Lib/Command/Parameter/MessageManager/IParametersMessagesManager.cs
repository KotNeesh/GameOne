using SimpleTeam.Command;
using SimpleTeam.Message.Manager;

namespace SimpleTeam.GameOne.Command
{
    public interface IParameterMessagesManager : IParameter
    {
        IMessagesManagerScenario GetMessagesManager();
    }
}
