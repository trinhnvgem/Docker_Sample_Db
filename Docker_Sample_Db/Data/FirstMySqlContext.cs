using Microsoft.EntityFrameworkCore;

namespace Docker_Sample_Db.Data
{
    public class FirstMySqlContext : SqlDBContext
    {
        public FirstMySqlContext(DbContextOptions<FirstMySqlContext> options) : base(options)
        {
        }
    }
}
