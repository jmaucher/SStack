using System.Collections.Generic;

namespace SStack.DataAccess
{
	public interface IQueryableByComparer
	{
		IList<Extent> Query<Extent>(IComparer<Extent> comparer);
	}
}
