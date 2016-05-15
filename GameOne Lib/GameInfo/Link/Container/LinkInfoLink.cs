using UnityEngine;
using System.Collections.Generic;
using System;
using System.Collections;

namespace SimpleTeam.GameOne.GameInfo
{
    public class LinkInfoList : ILinkInfoContainer
    {
        private List<SimplusLinkInfo> _container;


        public uint CurCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        public uint MaxCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerator GetEnumerator()
        {
            return _container.GetEnumerator();
        }
    }
}
