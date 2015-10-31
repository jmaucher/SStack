using System;

namespace SStack.LogicFacade
{
	public interface ILogicFacade : IDisposable
	{
		IInitContext AcquireInitContext(InitOptions options);
	}
}
