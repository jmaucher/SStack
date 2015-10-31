namespace SStack.CacheAccess
{
	public interface ICacheTextManagerFactory
	{
		ICacheTextManager Resolve(string contentType);
	}
}
