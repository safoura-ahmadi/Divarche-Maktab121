using Divarcheh.Domain.Core.Dto.Dashboard;

namespace Divarcheh.Domain.Core.Contracts.AppService
{
    public interface IDashboardAppService
    {
        StatisticsDataDto GetStatisticsData();
    }
}
