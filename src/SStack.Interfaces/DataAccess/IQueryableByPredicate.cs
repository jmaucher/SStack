using System;
using System.Collections.Generic;

namespace SStack.DataAccess
{
	public interface IQueryableByPredicate
	{
		IList<Extent> Query<Extent>(Predicate<Extent> match);
	}
}
