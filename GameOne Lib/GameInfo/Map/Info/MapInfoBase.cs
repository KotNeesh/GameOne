using System;
using System.Collections;
using System.Collections.Generic;

namespace SimpleTeam.GameOne.GameInfo
{
    using GameID = UInt16;
    public abstract class MapInfoBase : IMapInfo
    {
        protected IGameObjContainer<ISimplusInfo> _containerSimplus;
        protected MapInfoBase()
        {
            _containerSimplus = new GameObjList<ISimplusInfo>();
        }
        public IGameObjContainer<ISimplusInfo> GetContainerSimplus()
        {
            return _containerSimplus;
        }
    }
}
