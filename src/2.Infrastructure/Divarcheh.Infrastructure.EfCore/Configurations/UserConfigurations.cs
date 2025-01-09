using System.Security.Cryptography.X509Certificates;
using Divarcheh.Domain.Core.Entities.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Divarcheh.Infrastructure.EfCore.Configurations
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Users");

            builder.Property(x => x.Email).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Password).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Mobile).HasMaxLength(11).IsRequired();

            builder.HasMany(x => x.UserAdvertisements)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasData(new List<User>()
            {
                new User() {Id = 1 , RoleId = 1 , UserName = "Admin" , Email = "Admin@Admin.com" ,Mobile = "09123456789",CityId = 1,Password = "123456" ,RegisterAt = DateTime.Now }
            });
        }
    }
}
