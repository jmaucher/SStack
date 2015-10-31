namespace SStack.DataAccess.Criteria
{
	public interface IPagingCriteria : ICriteria
	{
		uint ResultOffset { get; }
		uint ResultLimit { get; }
	}
}
