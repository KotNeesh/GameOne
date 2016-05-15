using System.Collections.Generic;

namespace SimpleTeam.GameOne.GameInfo
{
    public interface ILinkInfoContainer : IEnumerable<ISimplusLinkInfo>
    {
        int MaxCount { get; }
        int CurCount { get; }
    }
}
