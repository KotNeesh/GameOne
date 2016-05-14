using System;
using SimpleTeam.Command;
using SimpleTeam.Message;

namespace SimpleTeam.GameOneID.Command
{
    using TypeID = Byte;
    public abstract class CommandProcessMessageAdapterSceneGame : ICommandProcessMessage
    {
        public abstract byte Type { get; }
        public TypeID GetParameterType()
        {
            return (TypeID)HelperParameterID.SceneGame;
        }
        public void Do(IParameters parameters, IMessage message)
        {
            DoMy(parameters as IParametersSceneGame, message);
        }
        protected abstract void DoMy(IParametersSceneGame parameter, IMessage message);
        
    }
}
