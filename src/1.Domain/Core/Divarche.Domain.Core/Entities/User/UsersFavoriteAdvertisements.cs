namespace Divarcheh.Domain.Core.Entities.User
{
    public class UsersFavoriteAdvertisements
    {
        public User User { get; set; }
        public int UserId { get; set; }

        public Advertisement.Advertisement Advertisement { get; set; }
        public int AdvertisementId { get; set; }
    }
}
