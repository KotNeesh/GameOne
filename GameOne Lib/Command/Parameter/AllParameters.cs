using System;
using System.Collections.Generic;
using SimpleTeam.Command.Scenario;

namespace SimpleTeam.Command
{
    using TypeID = Byte;
    public class AllParameters : IAllParameters
    {
        protected List<IParameters> _parameters;
        protected AllParameters()
        {
            _parameters = new List<IParameters>();
        }
        public AllParameters(List<IParameters> parameters)
        {
            _parameters = parameters;
        }
        public List<IScenario> GetAllScenario()
        {
            List<IScenario> scenarios = new List<IScenario>();
            foreach (IParameters p in _parameters)
            {
                IScenario s = p.GetScenario();
                if (s != null)
                {
                    scenarios.Add(s);
                }
            }
            return scenarios;
        }
        public IParameters GetParameters(TypeID ID)
        {
            foreach (IParameters p in _parameters)
            {
                if (p.Type == ID)
                {
                    return p;
                }
            }
            return null;
        }
    }
}
