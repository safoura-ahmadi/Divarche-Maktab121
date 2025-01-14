using Divarcheh.Domain.Core.Contracts.AppService;
using Divarcheh.Domain.Core.Contracts.Service;
using Divarcheh.Domain.Core.Dto.Dashboard;

namespace Divarcheh.Domain.AppServices
{
    public class DashboardAppService : IDashboardAppService
    {
        private readonly IUserService _userService;

        public DashboardAppService(IUserService userService)
        {
            _userService = userService;
        }

        public StatisticsDataDto GetStatisticsData()
        {
            var model = new StatisticsDataDto();

            model.UserCount = _userService.GetCount();
            model.AdvertisementCount = 10;
            model.CategoryCount = 15;
            model.BrandCount = 3;

            return model;
        }
    }
}
