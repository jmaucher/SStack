using SStack.DataAccess;

namespace SStack.CacheAccess
{
	public interface IPersistenceProviderCacheFactory
	{
		IPersistenceProviderCache Create(IPersistenceProviderManager providerManager);
		
		IPersistenceProviderCache Create(string conntectionString);
	}
}
