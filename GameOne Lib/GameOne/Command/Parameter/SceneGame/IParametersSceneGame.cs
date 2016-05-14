using SimpleTeam.GameOneID.Scene;
using SimpleTeam.Command;

namespace SimpleTeam.GameOneID.Command
{
    public interface IParametersSceneGame : IParameters
    {
        ISceneGame GetSceneGame();
    }
}

