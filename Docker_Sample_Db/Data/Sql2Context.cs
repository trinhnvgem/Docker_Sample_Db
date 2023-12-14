using Microsoft.EntityFrameworkCore;

namespace Docker_Sample_Db.Data
{
    public class Sql2Context : SqlDBContext
    {
        public Sql2Context(DbContextOptions<Sql2Context> options) : base(options)
        {
        }
    }
}
