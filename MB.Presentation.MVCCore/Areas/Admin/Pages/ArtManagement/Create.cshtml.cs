
using MB.Applications.Contracts.Art;
using MB.Applications.Contracts.ArtCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MB.Presentation.MVCCore.Areas.Admin.Pages.ArtManagement
{
    public class CreateModel : PageModel
    {
        public List<SelectListItem> ArtCategories { get; set; }
        private readonly IArtApplication _artApplication;
        private readonly IArtCategoryApplication _artCategoryApplication;
        public CreateModel(IArtApplication artApplication, IArtCategoryApplication artCategoryApplication)
        {
            _artApplication = artApplication;
            _artCategoryApplication = artCategoryApplication;
        }
        public void OnGet()
        {
            ArtCategories = _artCategoryApplication.List_See_Web().Where(x => x.IsDelete == false).Select(c => new SelectListItem(c.Title, c.Id.ToString())).ToList();
        }
        public RedirectToPageResult OnPost(ArtCreate artCreate)
        {
            _artApplication.Create(artCreate);
            return RedirectToPage("./list");
        }
    }
}
