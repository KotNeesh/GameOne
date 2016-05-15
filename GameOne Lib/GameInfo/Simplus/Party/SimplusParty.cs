using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleTeam.GameOne.GameInfo
{
    public class SimplusParty
    {
        public uint ID { get; set; }
        public bool IsMy(SimplusParty party)
        {
            return ID == party.ID;
        }
    }
}
