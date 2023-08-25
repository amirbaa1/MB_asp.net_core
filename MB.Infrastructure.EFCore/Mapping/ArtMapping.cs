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
            builder.Property(x => x.ShortDescription);
            builder.Property(x => x.Image);
            builder.Property(x => x.Context);
            builder.Property(x => x.CreatTime);
            builder.Property(x => x.IsDelete);

            builder.HasOne(x=>x.ArtCategory).WithMany(x=>x.arts).HasForeignKey(x=>x.ArtCategoryId);
        }
    }
}
