using System;
using System.Threading;
using SStack.DesignPatterns.Command;

namespace SStack.Common.Support
{
    public class ActionExecHandler : ICommandExec
    {
        private readonly Action action;
        private readonly AutoResetEvent waitHandle;

        public ActionExecHandler(Action action, AutoResetEvent waitHandle)
        {
            this.action = action;
            this.waitHandle = waitHandle;
        }

        public bool Execute()
        {
            action();
            waitHandle.Set();
            return true;
        }
    }
}
