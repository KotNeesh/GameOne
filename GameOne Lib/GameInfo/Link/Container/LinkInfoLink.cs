using UnityEngine;
using System.Collections.Generic;
using System;
using System.Collections;

namespace SimpleTeam.GameOne.GameInfo
{
    using GameID = UInt16;
    public class LinkInfoList : ILinkInfoContainer
    {

        private GameObjInfoList<ISimplusLinkInfo> _container;
        private int _maxCount;
        public LinkInfoList()
        {
            _container = new GameObjInfoList<ISimplusLinkInfo>();
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

        public int Count
        {
            get
            {
                return _container.Count;
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

        public IEnumerable<ISimplusLinkInfo> GetEnumerable()
        {
            return _container;
        }

        public ISimplusLinkInfo GetObj(GameID ID)
        {
            return _container.GetObj(ID);
        }

        public void SetObj(ISimplusLinkInfo gameObj)
        {
            _container.SetObj(gameObj);
        }

        public IEnumerator<ISimplusLinkInfo> GetEnumerator()
        {
            return _container.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _container.GetEnumerator();
        }
    }
}
