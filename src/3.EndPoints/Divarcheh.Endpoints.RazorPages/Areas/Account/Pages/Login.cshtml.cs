using Divarcheh.Domain.Core.Entities.Configs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Divarcheh.Endpoints.RazorPages.Areas.Account.Pages
{

    public class LoginViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }

    }

    public class LoginModel(SiteSettings siteSettings) : PageModel
    {

        [BindProperty]
        public LoginViewModel PageModel { get; set; }

        public IActionResult OnGet()
        {
            HttpContext.Request.Cookies.TryGetValue("ApiKey", out var apiKey);

            if (apiKey == siteSettings.ApiKey)
            {
               return RedirectToPage("Logout");
            }

            return Page();

        }

        public IActionResult OnPost()
        {
            if (PageModel.Username.ToUpper() == "Admin".ToUpper() && PageModel.Password.ToUpper() == "Admin".ToUpper())
            {
                var apiKey = siteSettings.ApiKey;

                HttpContext.Response.Cookies.Append("ApiKey", apiKey, new CookieOptions()
                {
                    Expires = DateTime.Now.AddHours(24)
                });

                return RedirectToPage("Index");
            }

            return RedirectToPage("Login");
        }
    }
}
