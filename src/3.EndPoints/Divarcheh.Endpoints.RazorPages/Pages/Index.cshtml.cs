using Divarcheh.Domain.Core.Entities.User;
using Hangfire;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Divarcheh.Endpoints.RazorPages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IBackgroundJobClient _backgroundJob;
        private readonly UserManager<User> _userManager;


        public IndexModel(ILogger<IndexModel> logger, IBackgroundJobClient backgroundJob, UserManager<User> userManager)
        {
            _logger = logger;
            _backgroundJob = backgroundJob;
            _userManager = userManager;
        }

        [Authorize(Roles = "Visitor")]
        public async Task OnGet()
        {

            var claims = User.Claims;

            _backgroundJob
                .Schedule(() => SendEmail(), DateTime.Now.AddMinutes(10));

            SetLog();
            
            _backgroundJob.Enqueue(() => SetLog());
        }

        public void SendEmail()
        {

        }

        public void RemoveLogs()
        {

        }

        public void SetLog()
        {

        }
    }
}
