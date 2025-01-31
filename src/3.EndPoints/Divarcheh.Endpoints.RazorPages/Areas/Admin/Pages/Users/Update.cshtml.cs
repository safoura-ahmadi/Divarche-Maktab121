using Divarcheh.Domain.Core.Contracts.AppService;
using Divarcheh.Domain.Core.Dto.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Divarcheh.Endpoints.RazorPages.Areas.Admin.Pages.Users
{
    public class UpdateModel(IUserAppService userAppService) : PageModel
    {
        [BindProperty]
        public UserDto User { get; set; }

        public async Task OnGet(int id,CancellationToken cancellationToken)
        {
            User = await userAppService.GetById(id, cancellationToken);
        }

        public async Task<IActionResult> OnPost(CancellationToken cancellationToken)
        {
            await userAppService.Update(User, cancellationToken);
            return RedirectToPage("Index");
        }
    }
}
