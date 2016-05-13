using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleTeam.Command.Scenario
{
    public interface IParametersScenar : IParameters
    {
        List<IScenario> GetAllScenario();
    }
}
