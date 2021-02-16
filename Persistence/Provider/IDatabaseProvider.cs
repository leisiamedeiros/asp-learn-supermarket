using System.Data.Common;

namespace Supermarket.Persistence.Provider
{
    public interface IDatabaseProvider
    {
        DbConnection GetDbConnection();
    }
}