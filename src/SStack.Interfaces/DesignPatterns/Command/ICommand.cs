namespace SStack.DesignPatterns.Command
{
    public interface ICommand<ReturnType>
    {
        ReturnType Execute();
    }
}
