using MB.Domain.ArtCategoryAgg;
using MB.Infrastructure.EFCore.Mapping;
using Microsoft.EntityFrameworkCore;


namespace MB.Infrastructure.EFCore
{
    public class MBContext : DbContext
    {
        public DbSet<ArtCategory> ArtCategories { get; set; }
        public MBContext(DbContextOptions<MBContext> options) :base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArtCategoryMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
