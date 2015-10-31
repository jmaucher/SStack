using System.Collections.Generic;

namespace SStack.DataAccess
{
	public interface IQueryableByExample
	{
		IList<Extent> QueryByExample<Extent>(object template);
	}
}
