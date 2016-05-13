using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleTeam.Scene
{
    interface ISimplusHPServer : ISimplusHP
    {
        bool Attack(int HP);
        void Defense(int HP);
    }
}
