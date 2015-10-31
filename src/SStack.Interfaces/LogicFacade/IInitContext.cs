using System;

namespace SStack.LogicFacade
{
	public interface IInitContext : IDisposable
	{
		object InitialisedObject
		{
			get;
		}
	}
}
