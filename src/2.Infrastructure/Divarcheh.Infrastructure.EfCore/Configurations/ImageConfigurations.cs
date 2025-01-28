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

            builder.HasData(new List<Image>()
            {
                new Image() { Id = 1, AdvertisementId = 1, Path = "Images/trending/1.jpg" },
                new Image() { Id = 2, AdvertisementId = 2, Path = "Images/trending/2.jpg" },
                new Image() { Id = 3, AdvertisementId = 2, Path = "Images/trending/4.jpg" },
                new Image() { Id = 4, AdvertisementId = 3, Path = "Images/trending/3.jpg" },
                new Image() { Id = 5, AdvertisementId = 4, Path = "Images/trending/5.jpg" }
            });
        }
    }
}
