using Docker_Sample_Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace Docker_Sample_Db.Data
{
    public abstract partial class SqlDBContext : DbContext
    {
        public SqlDBContext(DbContextOptions options) : base(options)
        {
           
        }

        public DbSet<Product> Products { get; set; }
    }
}
