using Hangfire;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Divarcheh.Endpoints.RazorPages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IBackgroundJobClient _backgroundJob;

        public IndexModel(ILogger<IndexModel> logger, IBackgroundJobClient backgroundJob)
        {
            _logger = logger;
            _backgroundJob = backgroundJob;
        }

        public void OnGet()
        {
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
