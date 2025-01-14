using Divarcheh.Domain.Core.Contracts.AppService;
using Divarcheh.Domain.Core.Dto.Dashboard;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Divarcheh.Endpoints.RazorPages.Areas.Admin.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IDashboardAppService _dashboardAppService;


        public IndexModel(IDashboardAppService dashboardAppService)
        {
            _dashboardAppService = dashboardAppService;
        }

        [BindProperty]
        public StatisticsDataDto DashboardData { get; set; }

        public void OnGet()
        {
            DashboardData = _dashboardAppService.GetStatisticsData();
        }
    }
}
