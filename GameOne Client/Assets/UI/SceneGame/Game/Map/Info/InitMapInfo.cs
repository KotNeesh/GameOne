using UnityEngine;
using System.Collections.Generic;
using System.Collections;

namespace SimpleTeam.GameOneID.Scene
{
    public class InitMapInfo : IMapInfo
    {
        private ArrayList _simplusInfo;
        public ArrayList SimplusInfo { get { return _simplusInfo; } }
    }
}
