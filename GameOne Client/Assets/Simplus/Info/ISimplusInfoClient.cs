using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleTeam.GameOne.Scene
{
    interface ISimplusInfoClient : ISimplusInfo
    {
        void IncHP(int HP, SimplusInfo source);
    }
}
