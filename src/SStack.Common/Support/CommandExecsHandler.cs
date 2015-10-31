using System.Threading;
using SStack.DesignPatterns.Command;

namespace SStack.Common.Support
{
    public class CommandExecsHandler : ICommandExec
    {
        private readonly ICommandExec command;
        private readonly AutoResetEvent waitHandle;

        public CommandExecsHandler(ICommandExec command, AutoResetEvent waitHandle)
        {
            this.command = command;
            this.waitHandle = waitHandle;
        }

        public bool Execute()
        {
            command.Execute();
            waitHandle.Set();
            return true;
        }
    }
}
