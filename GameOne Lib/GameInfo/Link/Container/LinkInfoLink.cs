using UnityEngine;
using System.Collections.Generic;
using System;
using System.Collections;

namespace SimpleTeam.GameOne.GameInfo
{
    using GameID = UInt16;
    public class LinkInfoList : ILinkInfoContainer
    {
        private List<ISimplusLinkInfo> _container;
        private int _maxCount;
        public LinkInfoList()
        {
            _container = new List<ISimplusLinkInfo>();
            _maxCount = 3;

        }

        public int CurCount
        {
            get
            {
                return _container.Count;
            }
        }
        public int MaxCount
        {
            get
            {
                return _maxCount;
            }
        }
        public ISimplusLinkInfo GetLinkInfo(GameID ID)
        {
            foreach (ISimplusLinkInfo l in _container)
            {
                if (l.ID == ID)
                {
                    return l;
                }
            }
            return null;
        }

        public IEnumerator<ISimplusLinkInfo> GetEnumerator()
        { 
            return _container.GetEnumerator();
        }

        

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    
    }
}
