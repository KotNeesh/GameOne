using SimpleTeam.GameOneID.Scene;
using SimpleTeam.Message.Manager;
using System;

namespace SimpleTeam.GameOneID.Command
{
    using SimpleTeam.Command.Scenario;
    using TypeID = Byte;
    public class ParametersMessagesManager : IParametersMessagesManager
    {
        public TypeID Type
        {
            get
            {
                return (TypeID)HelperParameterID.MessageManager;
            }
        }
        IMessagesManagerScenario _manager;
        public ParametersMessagesManager(IMessagesManager manager)
        {
            _manager = manager;
        }
        public IMessagesManagerScenario GetMessagesManager()
        {
            return _manager;
        }

        public IScenario GetScenario()
        {
            return _manager.GetScenario();
        }
    }
}
