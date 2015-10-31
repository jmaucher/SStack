namespace SStack.DataAccess
{
	public interface IPersistenceProviderManagerFactory
	{
		IPersistenceProviderManager CreateProviderManager(string connectionString);
	}
}
