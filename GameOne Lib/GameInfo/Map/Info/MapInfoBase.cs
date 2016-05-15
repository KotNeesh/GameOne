using System;
using System.Collections;
using System.Collections.Generic;

namespace SimpleTeam.GameOne.GameInfo
{
    using GameID = UInt16;
    public abstract class MapInfoBase : IMapInfo
    {
        protected List<ISimplusInfo> _container;
        protected MapInfoBase()
        {
            _container = new List<ISimplusInfo>();
        }


        public ISimplusInfo GetSimplusInfo(GameID ID)
        {
            foreach(ISimplusInfo s in _container)
            {
                if (s.ID == ID)
                {
                    return s;
                }
            }
            return null;
        }

        public void SetSimplusInfo(ISimplusInfo simplus)
        {
            _container.Add(simplus);
        }

        public IEnumerator<ISimplusInfo> GetEnumerator()
        {
            return _container.GetEnumerator();
        }

        

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        
    }
}
