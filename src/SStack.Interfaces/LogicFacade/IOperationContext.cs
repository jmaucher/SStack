using System;
using SStack.ServiceHost;

namespace SStack.LogicFacade
{
	public interface IOperationContext : IDisposable
	{
		IApplicationContext Application { get;  }
		
		IRequestContext Request { get; }
	}
}
