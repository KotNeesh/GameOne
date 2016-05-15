using System;
using System.Collections;
using System.Linq;
using UnityEngine;

namespace SimpleTeam.GameOne.Scene
{
    public class Simplus : MonoBehaviour
    {
        public SimplusWrapper _wrapper;

        private SimplusInfo _info;

        private ArrayList _links;

        //rm
        public GameObject LinkPrefab;

        //rm
        private SimplusLink _link;

        //public SimplusInfo Info { get; set; }

        public Simplus()
        {
            //_wrapper = new SimplusWrapper();
        }

        public void InitInfo(SimplusInfo info)
        {
            gameObject.transform.position = info.Obj2D.GetPos();

            SetInfo(info);
        }

        public void SetInfo(SimplusInfo info)
        {
            foreach (SimplusLinkInfo inf in info.Links.InfoContainer)
            {
                //if (inf.Equals(_links)
                //    continue;
                HandleLink(inf);
            }
            //go through link list (info)
            //if there are not the same
            //update links (create if needed)
            //update info
            

            _info.SetInfo(info);
        }

        public void HandleLink(SimplusLinkInfo info)
        {
            if (null == _links[info.Id])
            {
                CreateLink(info);
            }
            if (null != _links[info.Id] && null != info)
            {

            }

            UpdateLink(info);
        }

        public void UpdateLink(SimplusLinkInfo info)
        {
            (_links[info.Id] as SimplusLink).Info = info;
            
        }

        public void CreateLink(SimplusLinkInfo info)
        {
            //?
            //? somehow get Simplus destination
            //?
            var dest = new Simplus();
            _links.Add(CreateLink(dest));
        }

        public void DestroyLink(SimplusLinkInfo info)
        {
            (_links[info.Id] as SimplusLink).Destroy();
            _links.RemoveAt(info.Id);
        }

        //rm
        public SimplusLink CreateLink(Simplus destination)
        {
            //_link = new SimplusLink(this, destination);
            GameObject linkObj = Instantiate(LinkPrefab);
            _link = linkObj.GetComponent<SimplusLink>();
            _link.SetSimplusLinkData(this, destination);
            return _link;
        }

        //public bool IsFocused(Vector2 focusPos)
        //{
        //    return _wrapper.IsFocused(focusPos);
        //}
    }
}
