using Microsoft.EntityFrameworkCore;

namespace CleanArch.InfraData.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Domain.Entities.Category> Categories { get; set; }
        public DbSet<Domain.Entities.Product> Products { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}
