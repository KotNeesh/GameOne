﻿using SimpleTeam.Command.Scenario;

namespace SimpleTeam.Command
{
    public interface IParameters : ITypeID
    {
        IScenario GetScenario();
    }
}
