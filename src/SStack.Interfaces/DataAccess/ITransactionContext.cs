using System;

namespace SStack.DataAccess
{
    public interface ITransactionContext : IDisposable
    {
        bool Commit();
        bool Rollback();
    }
}
