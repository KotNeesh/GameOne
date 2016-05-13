using System;


namespace SimpleTeam.Message
{
    using TypeID = Byte;
    /**
    <summary>
    Интерфейс определения ID класса.
    </summary>
    */
    public interface ITypeID
    {
        TypeID Type { get; }
    }
}
