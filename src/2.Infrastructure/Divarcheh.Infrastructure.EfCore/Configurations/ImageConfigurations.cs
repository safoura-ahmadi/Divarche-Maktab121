using Divarcheh.Domain.Core.Entities.BaseEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Divarcheh.Infrastructure.EfCore.Configurations
{
    public class ImageConfigurations : IEntityTypeConfiguration<Image>

    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Images");
            builder.Property(x => x.Path).HasMaxLength(500).IsRequired();

            builder.HasOne(x => x.Advertisement)
                .WithMany(x => x.Images)
                .HasForeignKey(x => x.AdvertisementId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.Category)
                .WithOne(x => x.Image)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
