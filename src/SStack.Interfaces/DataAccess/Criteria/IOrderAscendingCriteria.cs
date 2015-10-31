namespace SStack.DataAccess.Criteria
{
	public interface IOrderAscendingCriteria : ICriteria
	{
		string OrderedAscendingBy { get; }
	}
}
