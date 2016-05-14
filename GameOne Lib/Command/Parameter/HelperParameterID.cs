using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleTeam.GameOne.Command
{
    using TypeID = Byte;
    /**
    <summary> 
    Реестр всех типов сообщений.
    </summary>
    */
    public enum HelperParameterID : TypeID
    {
        None,
        MessageManager,
        SceneMenu,
        SceneGame
    }
}
