using Microsoft.EntityFrameworkCore;

namespace Mission10API.Data
{
    public class BowlingContext : DbContext
    {
        public BowlingContext(DbContextOptions<BowlingContext> options) : base(options) { }
        public DbSet<BowlingLeague> Players { get; set; }
    }
}
