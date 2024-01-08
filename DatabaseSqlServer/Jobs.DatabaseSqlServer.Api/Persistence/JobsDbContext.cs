using Jobs.DatabaseSqlServer.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Jobs.Api.Persistence
{
    public class JobsDbContext : DbContext
    {
        public JobsDbContext(DbContextOptions<JobsDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Job> Jobs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Job>(o =>
            {
                o.HasKey(j => j.Id);
                o.Property(j => j.Title).IsRequired().HasMaxLength(25);
                o.Property(j => j.Description).IsRequired().HasMaxLength(25);
                o.Property(j => j.Company).IsRequired().HasMaxLength(25);
                o.Property(j => j.Location).IsRequired().HasMaxLength(25);
            });
        }
    }
}
