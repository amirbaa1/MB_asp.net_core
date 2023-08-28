using MB.Domain.ArtCategoryAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MB.Infrastructure.EFCore.Mapping
{
    public class ArtCategoryMapping : IEntityTypeConfiguration<ArtCategory>
    {
        public void Configure(EntityTypeBuilder<ArtCategory> builder)
        {
            builder.ToTable(nameof(ArtCategory));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title);
            builder.Property(x => x.IsDeleted);
            builder.Property(x => x.CreateDate);

            builder.HasMany(x=>x.artes).WithOne(x=>x.ArtCategories).HasForeignKey(x=>x.ArtCategoryId);
                                                                 
        }
    }
}
