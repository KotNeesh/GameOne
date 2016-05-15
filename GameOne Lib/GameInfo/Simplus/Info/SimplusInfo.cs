using System;
using UnityEngine;

namespace SimpleTeam.GameOne.GameInfo
{
    using GameID = UInt16;
    public class SimplusInfo : ISimplusInfoClient, ISimplusInfoServer
    {
        private ILinkInfoContainer _links;
        private IObj2D _obj2D;
        private SimplusHP _hp;
        private SimplusParty _party;
        private GameID _id;
        public SimplusParty Party { get { return _party; } }
        public SimplusHP HP { get { return _hp; } }
        public IObj2D Obj2D { get { return _obj2D; } }
        public ILinkInfoContainer Links { get { return _links; } }

        public GameID ID
        {
            get
            {
                return _id;
            }
        }

        public SimplusInfo()
        {
            _obj2D = new Circle(Vector2.zero, 50);
            _hp = new SimplusHP();
            _party = new SimplusParty();
            _links = new LinkInfoList();
        }

        public void SetInfo(SimplusInfo info)
        {
            _hp = info.HP;
            _party = info.Party;
            _obj2D = info.Obj2D;
            //? reference
            _links = info._links;
        }

        void ISimplusInfoServer.IncHP(int HP, SimplusInfo source)
        {
            if (!_party.IsMy(source.Party))
            {
                bool isСaptured = _hp.Attack(HP);
                if (isСaptured)
                    _party.ID = source.Party.ID;
            }
            else
            {
                _hp.Defense(HP);
            }
        }

        void ISimplusInfoClient.IncHP(int HP, SimplusInfo source)
        {
            if (!_party.IsMy(source.Party))
                HP *= -1;
            _hp.Inc(HP);
        }

        public ILinkInfoContainer GetLinks()
        {
            return _links;
        }
    }
}
