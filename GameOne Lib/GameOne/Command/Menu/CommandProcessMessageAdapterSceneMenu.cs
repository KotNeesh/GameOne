using System;
using SimpleTeam.Command;
using SimpleTeam.Message;

namespace SimpleTeam.GameOneID.Command
{
    using TypeID = Byte;
    public abstract class CommandProcessMessageAdapterSceneMenu : ICommandProcessMessage
    {
        public abstract byte Type { get; }
        public TypeID GetParameterType()
        {
            return (TypeID)HelperParameterID.SceneMenu;
        }
        public void Do(IParameters parameters, IMessage message)
        {
            DoMy(parameters as IParametersSceneMenu, message);
        }
        protected abstract void DoMy(IParametersSceneMenu parameter, IMessage message);

    }
}
