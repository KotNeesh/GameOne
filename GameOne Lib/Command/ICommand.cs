
namespace SimpleTeam.Command
{
    /**
    <summary>
    Команда исполняющая сценарную операцию.
    </summary>
    */
    public interface ICommand
    {

        void Do(IParameters parameters);
    }
}
