using System;

namespace SStack.CacheAccess
{
	public interface ICompressableCacheTextManager
		: IHasCacheClient, ICacheHasContentType, ICacheClearable
	{
		object Resolve<T>(string compressionType, string cacheKey, Func<T> createCacheFn) 
			where T : class;
	}
}
