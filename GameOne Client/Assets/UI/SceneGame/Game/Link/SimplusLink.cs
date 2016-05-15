﻿using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using SimpleTeam.GameOne.GameInfo;

namespace SimpleTeam.GameOne.Scene
{
    public class SimplusLink : MonoBehaviour
    {
        public SimplusLinkWrapper _wrap;
        private SimplusLinkInfo _info;





        public void Destroy()
        {
            _info = null;
            Destroy(_wrap.gameObject);
        }

        //rm
        public void SetSimplusLinkData(Simplus source, Simplus destination)
        {
            Debug.Log("SimplusLink constr");
            SimplusWrapper ss = source._wrapper;
            SimplusWrapper dd = destination._wrapper;

            Vector2 s = ss.GetPosSurface(dd.GetPos());
            Vector2 d = dd.GetPosSurface(ss.GetPos());
            //_wrap = new SimplusLinkWrapper(s, d);
            _wrap.SetAnimationState(SimplusLinkActionState.Flying);
            _wrap.SetSimplusLinkWrapperData(s, d);
        }

        //rm
        private SimplusLinkActionState _state = SimplusLinkActionState.Transporting;

        public SimplusLinkWrapper Wrap
        {
            get
            {
                return _wrap;
            }

            set
            {
                _wrap = value;
            }
        }

        public SimplusLinkInfo Info
        {
            get
            {
                return _info;
            }

            set
            {
                _info = value;
            }
        }
    }
}
