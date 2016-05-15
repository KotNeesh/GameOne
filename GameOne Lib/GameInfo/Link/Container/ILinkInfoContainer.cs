using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace SimpleTeam.GameOne.GameInfo
{
    public interface ILinkInfoContainer : IEnumerable
    {
        uint MaxCount { get; }
        uint CurCount { get; }
    }
}
