namespace SStack.CacheAccess
{
	public interface IHasCacheClient
	{
		ICacheClient CacheClient { get; }
	}
}
