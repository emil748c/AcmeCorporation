using Domain;
using Microsoft.EntityFrameworkCore;
using Persistence.Seed;

namespace Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new SerialNumberSeed());
            base.OnModelCreating(builder);
        }
        public DbSet<SerialNumber> SerialNumbers { get; set; }
        public DbSet<Submission> Submissions { get; set; }
    }
}
