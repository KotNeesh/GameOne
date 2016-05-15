using UnityEngine;
using System.Collections.Generic;
using System.Collections;

namespace SimpleTeam.GameOne.GameInfo
{
    public class UpdateMapInfo : IMapInfo
    {
        private ArrayList _simplusInfo;
        public ArrayList SimplusInfo { get { return _simplusInfo; } }
    }
}