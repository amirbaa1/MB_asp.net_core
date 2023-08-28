using MB.Domain.ArtAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace MB.Infrastructure.EFCore.Mapping
{
    public class ArtMapping : IEntityTypeConfiguration<Art>
    {
        public void Configure(EntityTypeBuilder<Art> builder)
        {
            builder.ToTable("Art");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title);
            builder.Property(x => x.ShortText);
            builder.Property(x => x.Image);
            builder.Property(x => x.Context);
            builder.Property(x => x.CreatTime);
            builder.Property(x => x.IsDelete);


            builder.HasOne(c => c.ArtCategories)
                .WithMany(c => c.artes)
                .HasForeignKey(c => c.ArtCategoryId);

            builder.HasMany(x => x.Comments).WithOne(x => x.art).HasForeignKey(x => x.ArtId);
        }
    }
}
