using Divarcheh.Domain.Core.Contracts.AppService;
using Divarcheh.Domain.Core.Dto.Dashboard;
using Divarcheh.Domain.Core.Entities.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Divarcheh.Endpoints.RazorPages.Areas.Admin.Pages
{
    [Authorize(Roles = "Admin")]
    public class IndexModel : PageModel
    {
        private readonly IDashboardAppService _dashboardAppService;


        public IndexModel(IDashboardAppService dashboardAppService)
        {
            _dashboardAppService = dashboardAppService;
        }

        [BindProperty]
        public StatisticsDataDto DashboardData { get; set; }

        public async Task OnGet(CancellationToken cancellationToken)
        {
            var data = User;
            DashboardData = await _dashboardAppService.GetStatisticsData(cancellationToken);
        }
    }
}
