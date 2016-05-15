using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleTeam.GameOne.GameInfo
{
    interface ISimplusInfo : IGameID
    {
        SimplusParty Party { get; }
        SimplusHP HP { get; }
        IObj2D Obj2D { get; }

    }
}
