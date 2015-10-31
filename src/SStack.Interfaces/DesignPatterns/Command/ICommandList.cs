using System.Collections.Generic;

namespace SStack.DesignPatterns.Command
{
    public interface ICommandList<T> : ICommand<List<T>>
    {
    }
}
