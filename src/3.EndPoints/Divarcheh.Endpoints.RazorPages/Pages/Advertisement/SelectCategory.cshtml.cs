using Divarcheh.Domain.Core.Contracts.AppService;
using Divarcheh.Domain.Core.Dto.Advertisement;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Divarcheh.Endpoints.RazorPages.Pages.Advertisement
{
    public class SelectCategoryModel(ICategoryAppService categoryAppService) : PageModel
    {
        [BindProperty]
        public List<CategoryDto> Parents { get; set; }
        [BindProperty]
        public List<CategoryDto> Childs { get; set; }
        [BindProperty]
        public int ChildCategoryId { get; set; }
        [BindProperty]
        public int ParentId { get; set; }

        public async Task OnGet(int parentId, int childCategoryId,CancellationToken cancellationToken)
        {
            Parents = await categoryAppService.GetParentCategories(cancellationToken);
            if (parentId > 0)
            {
                Childs = await categoryAppService.GetChildCategories(parentId,cancellationToken);
            }
            else
            {
                var firstParentId = Parents.First().Id;
                Childs = await categoryAppService.GetChildCategories(firstParentId, cancellationToken);
             
            }
            ParentId = parentId;
            ChildCategoryId = childCategoryId;
        }
    }
}
