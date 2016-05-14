using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace SimpleTeam.GameOneID.Scene
{
    public class Simplus : MonoBehaviour
    {
        public SimplusWrapper _wrapper;
        public GameObject LinkPrefab;

        private SimplusLink _link;

        private SimplusInfo _info;

        //public SimplusInfo Info { get; set; }

        public Simplus()
        {
            //_wrapper = new SimplusWrapper();
        }

        public void InitInfo(SimplusInfo info)
        {
            gameObject.transform.position = info.Obj2D.GetPos();

            //info
        }

        public void CreateLink(Simplus destination)
        {
            //_link = new SimplusLink(this, destination);
            GameObject linkObj = Instantiate(LinkPrefab);
            _link = linkObj.GetComponent<SimplusLink>();
            _link.SetSimplusLinkData(this, destination);
        }

        //public bool IsFocused(Vector2 focusPos)
        //{
        //    return _wrapper.IsFocused(focusPos);
        //}
    }
}
