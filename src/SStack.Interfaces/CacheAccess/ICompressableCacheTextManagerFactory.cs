namespace SStack.CacheAccess
{
	public interface ICompressableCacheTextManagerFactory
	{
		ICompressableCacheTextManager Resolve(string contentType);
	}
}
