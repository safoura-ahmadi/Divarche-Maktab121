using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Divarcheh.Endpoints.RazorPages.Areas.Account.Pages
{
    public class LogoutModel : PageModel
    {
        public void OnGet()
        {
        }

        public IActionResult OnGetLogOut()
        {
            HttpContext.Response.Cookies.Delete("ApiKey");

            return RedirectToPage("Login");
        }
    }
}
