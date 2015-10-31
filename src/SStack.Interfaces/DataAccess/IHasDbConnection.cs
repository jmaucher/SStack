#if !SILVERLIGHT && !XBOX
using System.Data;

namespace SStack.DataAccess
{
	public interface IHasDbConnection
	{
		IDbConnection DbConnection { get; }
	}
}
#endif
