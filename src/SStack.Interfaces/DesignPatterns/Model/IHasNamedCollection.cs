using System.Collections.Generic;

namespace SStack.DesignPatterns.Model
{
	public interface IHasNamedCollection<T> : IHasNamed<ICollection<T>>
	{
	}
}
