using System;

namespace SStack.DataAccess
{
	/// <summary>
	/// Manages a connection to a persistance provider
	/// </summary>
	public interface IPersistenceProviderManager : IDisposable
	{
		IPersistenceProvider GetProvider();
	}
}
