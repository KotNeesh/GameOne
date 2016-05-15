using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleTeam.GameOne.GameInfo
{
    public interface ISimplusHPServer : ISimplusHP
    {
        bool Attack(int HP);
        void Defense(int HP);
    }
}
