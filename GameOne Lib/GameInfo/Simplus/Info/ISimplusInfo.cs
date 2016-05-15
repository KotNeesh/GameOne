using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleTeam.GameOne.Scene
{
    interface ISimplusInfo
    {
        SimplusParty Party { get; }
        SimplusHP HP { get; }
        IObj2D Obj2D { get; }
    }
}
