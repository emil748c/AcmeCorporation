using Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Persistence.Seed;
using System;

namespace Persistence
{
    public class ApplicationDbContext : IdentityDbContext
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
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
