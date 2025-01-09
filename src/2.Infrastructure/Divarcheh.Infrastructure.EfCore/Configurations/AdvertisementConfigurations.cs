using Divarcheh.Domain.Core.Entities.Advertisement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Divarcheh.Infrastructure.EfCore.Configurations
{
    public class AdvertisementConfigurations : IEntityTypeConfiguration<Advertisement>
    {
        public void Configure(EntityTypeBuilder<Advertisement> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Advertisements");

            builder.Property(x => x.Title).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(2000).IsRequired();
            builder.Property(x => x.Price).IsRequired();
        }
    }
}
