using System;
using MB.Domain.ArtAgg;
using MB.Domain.CommentAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MB.Infrastructure.EFCore.Mapping
{
    public class CommentMapping : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comments");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name);
            builder.Property(x => x.Email);
            builder.Property(x => x.Message);
            builder.Property(x => x.Status);
            builder.Property(x => x.SendMessage);
            builder.Property(x => x.ArtId);

            builder.HasOne(x => x.art).WithMany(x => x.Comments).HasForeignKey(x => x.ArtId);
        }
    }
}

