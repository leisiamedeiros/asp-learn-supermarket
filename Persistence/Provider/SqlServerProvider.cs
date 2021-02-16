using System.Data.Common;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Supermarket.Persistence.Provider
{
    public class SqlServerProvider : IDatabaseProvider
    {
        private readonly string _connectionString;
        public SqlServerProvider(string connectionString)
        {
            _connectionString = connectionString;
        }

        public SqlServerProvider(IConfiguration configuration)
        {
            _connectionString = configuration["ConnectionStrings:Container"];
        }

        public DbConnection GetDbConnection() => new SqlConnection(_connectionString);

    }
}