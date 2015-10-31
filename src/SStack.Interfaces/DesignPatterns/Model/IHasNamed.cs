namespace SStack.DesignPatterns.Model
{
	public interface IHasNamed<T>
	{
		T this[string listId] { get; set; }
	}
}
