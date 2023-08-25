using MB.Application;
using MB.Applications.Contracts.ArtCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentation.MVCCore.Areas.Admin.Pages.ArtCategoryMangement
{
    public class EditModel : PageModel
    {
        [BindProperty] public ArtCategoryRename artCategories { get; set; }

        private readonly IArtCategoryApplication _artCategoryApplication;
        public EditModel(IArtCategoryApplication artCategoryApplication)
        {
            _artCategoryApplication = artCategoryApplication;
        }
    
        public void OnGet(long id)
        {
            artCategories = _artCategoryApplication.Get(id);
        }


        public RedirectToPageResult OnPost()
        {
            _artCategoryApplication.Rename(artCategories);
            return RedirectToPage("./list");
        }

    }
}
