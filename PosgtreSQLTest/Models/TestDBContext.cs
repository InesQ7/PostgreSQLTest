using Microsoft.EntityFrameworkCore;

namespace PosgtreSQLTest.Models
{
    public class TestDBContext : DbContext
    {
        public TestDBContext(DbContextOptions<TestDBContext> options) : base(options) { }
        public DbSet<Items> Items { get; set; }
    }
}
