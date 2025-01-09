using Divarcheh.Domain.Core.Entities.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Divarcheh.Infrastructure.EfCore.Configurations
{
    public class UsersFavoriteAdvertisementsConfigurations : IEntityTypeConfiguration<UsersFavoriteAdvertisements>
    {
        public void Configure(EntityTypeBuilder<UsersFavoriteAdvertisements> builder)
        {
            builder.HasKey(x => new { x.UserId, x.AdvertisementId });

            builder.HasOne(x => x.Advertisement)
                .WithMany(x => x.UserFavoriteAdvertisments)
                .HasForeignKey(x => x.AdvertisementId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.User)
                .WithMany(x => x.FavoriteAdvertisements)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
