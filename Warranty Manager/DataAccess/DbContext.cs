using Microsoft.EntityFrameworkCore;
using DataAccess.Model;

namespace DataAccess
{
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContext(DbContextOptions<DbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
