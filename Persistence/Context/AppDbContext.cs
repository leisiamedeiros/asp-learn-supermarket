
using Microsoft.EntityFrameworkCore;

namespace Supermarket.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
    }
}