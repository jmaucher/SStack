using System.Collections.Generic;

namespace SStack.DesignPatterns.Command
{
    public interface ICommandIEnumerable<T> : ICommand<IEnumerable<T>>
    {
    }
}
