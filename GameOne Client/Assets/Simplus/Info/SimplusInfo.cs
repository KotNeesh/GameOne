﻿using UnityEngine;

namespace SimpleTeam.GameOne.Scene
{
    public class SimplusInfo : ISimplusInfoClient, ISimplusInfoServer
    {
        private ContainerLink _links;
        private IObj2D _obj2D;
        private SimplusHP _hp;
        private SimplusParty _party;
        public SimplusParty Party { get { return _party; } }
        public SimplusHP HP { get { return _hp; } }
        public IObj2D Obj2D { get { return _obj2D; } }

        public SimplusInfo()
        {
            _obj2D = new Circle(Vector2.zero, 50);
            _hp = new SimplusHP();
            _party = new SimplusParty();
            _links = new ContainerLink();
        }

        public void SetInfo(SimplusInfo info)
        {

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
    }
}
