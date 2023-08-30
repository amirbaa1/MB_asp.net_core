
using MB.Applications.Contracts.ArtCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentation.MVCCore.Areas.Admin.ArtCategoryMangement
{
	public class ListModel : PageModel
    {
        public List<ArtCategoryViewModel> ArtCategoryViewModels { get; set; }
        private readonly IArtCategoryApplication _artCategoryApplication;
        public ListModel(IArtCategoryApplication artCategoryApplication)
        {
            _artCategoryApplication = artCategoryApplication;
        }
        public void OnGet()
        {
            ArtCategoryViewModels = _artCategoryApplication.List_See_Web().OrderBy(x=>x.Id).ToList();
        }
        public IActionResult OnPost(ArtCategoryCreate command)
        {
            return RedirectToPage("./list");
        }
        public RedirectToPageResult OnPostDelete(int id)
        {
            _artCategoryApplication.Delete(id);
            return RedirectToPage("./list");
        }
        public IActionResult OnPostActivate(int id) 
        {
            _artCategoryApplication.Activate(id);
            return RedirectToPage("./list");
        }
        public IActionResult OnPostRemove(int id)
        {
            _artCategoryApplication.Remove(id);
            return RedirectToPage("./list");
        }
    }
}
