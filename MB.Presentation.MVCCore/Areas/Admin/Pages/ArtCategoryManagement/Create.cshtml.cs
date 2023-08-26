using MB.Applications.Contracts.Art;
using MB.Applications.Contracts.ArtCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MB.Presentation.MVCCore.Areas.Admin.Pages.ArtCategoryMangement
{
    public class CreateModel : PageModel
    {
        private readonly IArtCategoryApplication _artCategoryApplication;
        public CreateModel(IArtCategoryApplication artCategoryApplication)
        {
            _artCategoryApplication = artCategoryApplication;
        }

        public void OnGet()
        {
        }
        public IActionResult OnPost(ArtCategoryCreate command)
        {
            _artCategoryApplication.Create(command);
             return RedirectToPage("./list");
        }
    }

}