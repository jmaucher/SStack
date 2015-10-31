using System.Collections.Generic;

namespace SStack.CacheAccess
{
	public interface ICacheClearable
	{
		void Clear(IEnumerable<string> cacheKeys);

		void Clear(params string[] cacheKeys);
	}
}
