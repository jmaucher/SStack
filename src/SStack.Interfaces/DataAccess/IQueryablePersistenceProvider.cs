using System.Collections.Generic;
using SStack.DataAccess.Criteria;

namespace SStack.DataAccess
{
	public interface IQueryablePersistenceProvider : IPersistenceProvider, IQueryable
	{
		IList<T> GetAll<T>(ICriteria criteria)
			where T : class, new();
	}
}
