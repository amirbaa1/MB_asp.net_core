using MB.Domain.ArtAgg;
using MB.Domain.ArtCategoryAgg;
using MB.Domain.CommentAgg;
using MB.Infrastructure.EFCore.Mapping;
using Microsoft.EntityFrameworkCore;


namespace MB.Infrastructure.EFCore
{
    public class MBContext : DbContext
    {
        public DbSet<ArtCategory> ArtCategories { get; set; }
        public DbSet<Art> arts { get; set; }
        public DbSet<Comment> comments { get; set; }

        public MBContext(DbContextOptions<MBContext> options) : base(options) 
        { 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArtCategoryMapping());
            modelBuilder.ApplyConfiguration(new ArtMapping());
            modelBuilder.ApplyConfiguration(new CommentMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
