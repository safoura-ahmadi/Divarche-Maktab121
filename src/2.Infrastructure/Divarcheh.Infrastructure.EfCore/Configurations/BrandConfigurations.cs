using Divarcheh.Domain.Core.Entities.Advertisement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Divarcheh.Infrastructure.EfCore.Configurations
{
    public class BrandConfigurations : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).HasMaxLength(100).IsRequired();

            builder.HasMany(x => x.Advertisements)
                .WithOne(x => x.Brand)
                .HasForeignKey(x => x.BrandId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasData(new List<Brand>()
            {
                new Brand(){Id = 1 , Title = "Samsung"},
                new Brand(){Id = 2 , Title = "Lg"},
                new Brand(){Id = 3 , Title = "Sony"},
                new Brand(){Id = 4 , Title = "Apple"},
                new Brand(){Id = 5 , Title = "Huawei"},
                new Brand(){Id = 6 , Title = "Xiaomi"},
                new Brand(){Id = 7 , Title = "Nokia"},
            });
        }
    }
}
