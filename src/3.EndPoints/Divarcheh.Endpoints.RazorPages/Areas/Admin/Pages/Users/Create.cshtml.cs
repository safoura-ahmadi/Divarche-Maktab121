using Divarcheh.Domain.Core.Contracts.AppService;
using Divarcheh.Domain.Core.Dto.User;
using Divarcheh.Domain.Core.Entities.BaseEntities;
using Divarcheh.Domain.Core.Entities.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Divarcheh.Endpoints.RazorPages.Areas.Admin.Pages.Users
{
    public class CreateModel : PageModel
    {
        private readonly IBaseDataAppService _baseDataAppService;
        private readonly IUserAppService _userAppService;

        public CreateModel(IBaseDataAppService baseDataAppService, IUserAppService userAppService)
        {
            _baseDataAppService = baseDataAppService;
            _userAppService = userAppService;
        }

        [BindProperty]
        public UserDto User { get; set; }

        [BindProperty]
        public List<City> Cities { get; set; }

        [BindProperty]
        public List<Role> Roles { get; set; }
        public void OnGet()
        {
            Cities = _baseDataAppService.GetCities();
            Roles = _baseDataAppService.GetRoles();
        }


        public IActionResult OnPost()
        {
            _userAppService.Create(User);
            return RedirectToPage("Index");
        }
    }
}
