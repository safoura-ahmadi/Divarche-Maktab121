using Divarcheh.Domain.Core.Entities.Advertisement;
using Divarcheh.Domain.Core.Enum;
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


            builder.HasData(new List<Advertisement>()
            {
                new Advertisement()
                {
                    Id = 1, Title = "اپل تی وی - بهترین تلویزیون دنیا", Price = 50000, CityId = 1, CategoryId = 8,
                    BrandId = 1, CreateAt = DateTime.Now, Description = "Description",
                    AdvertisementType = AdvertisementTypeEnum.Seller,
                    AdvertisementFinalStatus = AdvertisementFinalStatusEnum.Approved,
                    Model = "2021",
                    UserId = 1
                },
                new Advertisement()
                {
                    Id = 2, Title = "مبلمان پارچه ، مبلمان دستباف دست ساز", Price = 80000, CityId = 5, CategoryId = 9,
                    BrandId = 2, CreateAt = DateTime.Now, Description = "Description",
                    AdvertisementType = AdvertisementTypeEnum.Seller,
                    AdvertisementFinalStatus = AdvertisementFinalStatusEnum.Approved,
                    Model = "2022",
                    UserId = 1

                },
                new Advertisement()
                {
                    Id = 3, Title = "ریک مورتون- مگیسیوس چیس", Price = 70000, CityId = 10, CategoryId = 8,
                    BrandId = 4, CreateAt = DateTime.Now, Description = "Description",
                    AdvertisementType = AdvertisementTypeEnum.Seller,
                    AdvertisementFinalStatus = AdvertisementFinalStatusEnum.Approved,
                    Model = "2024",
                    UserId = 1
                },
                new Advertisement()
                {
                    Id = 4, Title = "سامسونگ گلکسی اس 10", Price = 70000, CityId = 10, CategoryId = 6,
                    BrandId = 3, CreateAt = DateTime.Now, Description = "Description",
                    AdvertisementType = AdvertisementTypeEnum.Seller,
                    AdvertisementFinalStatus = AdvertisementFinalStatusEnum.Approved,
                    Model = "2024",
                    UserId = 1
                }
            });
        }
    }
}
