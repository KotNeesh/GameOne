using System.Collections.Generic;
using System;

namespace SimpleTeam.GameOne.GameInfo
{
    using GameID = UInt16;
    public interface ILinkInfoContainer : IEnumerable<ISimplusLinkInfo>
    {
        int MaxCount { get; }
        int CurCount { get; }
        ISimplusLinkInfo GetLinkInfo(GameID ID);
    }
}
