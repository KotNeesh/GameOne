﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleTeam.GameOne.Scene
{
    interface ISimplusHPClient : ISimplusHP
    {
        void Inc(int HP);
    }
}
