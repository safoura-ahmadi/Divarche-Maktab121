using Divarcheh.Domain.Core.Entities.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Divarcheh.Infrastructure.EfCore.Configurations
{
    public class RoleConfigurations : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Roles");
            builder.Property(x => x.Title).HasMaxLength(50).IsRequired();

            builder.HasMany(x => x.Users)
                .WithOne(x => x.Role)
                .HasForeignKey(x => x.RoleId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasData(new List<Role>()
            {
                new Role() {Id = 1 ,Title = "Admin"},
                new Role() {Id = 2 ,Title = "User"},
            });

        }
    }
}
