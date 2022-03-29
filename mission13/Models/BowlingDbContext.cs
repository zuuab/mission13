using System;
using Microsoft.EntityFrameworkCore;

namespace mission13.Models
{
    public class BowlingDbContext : DbContext
    {
        public BowlingDbContext(DbContextOptions<BowlingDbContext> options) : base(options)
        {

        }

        public DbSet<Bowler> Bowlers { get; set; }
    }
}
