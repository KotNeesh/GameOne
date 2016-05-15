using SimpleTeam.Main;
using SimpleTeam.GameOne.Command;
using System;

namespace SimpleTeam.Command
{
    using Scenario;
    using TypeID = Byte;
    public class ParameterMain : IParamaterMain
    {
        public TypeID Type
        {
            get
            {
                return (TypeID)HelperParameterID.Main;
            }
        }

        private IMain _main;
        public ParameterMain(IMain main)
        {
            _main = main;
        }
        public IScenario GetScenario()
        {
            return null;
        }
        public IMain GetMain()
        {
            return _main;
        }
    }
}
