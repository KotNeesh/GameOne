using System;
using System.Collections;
using System.Collections.Generic;

namespace SimpleTeam.GameOne.GameInfo
{
    using GameID = UInt16;
    public abstract class MapInfoBase : IMapInfo
    {
        protected IGameObjInfoContainer<ISimplusInfo> _containerSimplus;
        protected MapInfoBase()
        {
            _containerSimplus = new GameObjInfoList<ISimplusInfo>();
        }
        public IGameObjInfoContainer<ISimplusInfo> GetContainerSimplus()
        {
            return _containerSimplus;
        }
    }
}
