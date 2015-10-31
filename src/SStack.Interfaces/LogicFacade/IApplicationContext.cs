using SStack.CacheAccess;
using SStack.Configuration;

namespace SStack.LogicFacade
{
	public interface IApplicationContext
	{
		IFactoryProvider Factory { get; }

		T Get<T>() where T : class;

		ICacheClient Cache { get; }

		IResourceManager Resources { get; }
	}
}
