using MB.Applications.Contracts.Art;
using MB.Applications.Contracts.ArtCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MB.Presentation.MVCCore.Areas.Admin.Pages.ArtManagement
{
    public class EditModel : PageModel
    {
        [BindProperty]public ArtEdit arts { get;set; }
        private readonly IArtApplication _artApplication;
        private readonly IArtCategoryApplication _artCategoryApplication;
        public List<SelectListItem> ArtCategories { get; set; }
        public EditModel(IArtApplication artApplication,IArtCategoryApplication artCategoryApplication)
        {
            _artApplication = artApplication;
            _artCategoryApplication = artCategoryApplication;
        }
        public void OnGet(int id)
        {
            arts = _artApplication.Get(id);
            ArtCategories = _artCategoryApplication.List().Where(x=>x.IsDelete==false).Select(x => new SelectListItem(x.Title, x.Id.ToString())).ToList();
        }
        
        public RedirectToPageResult OnPost()
        {
            _artApplication.Edit(arts);
            return RedirectToPage("./List");
        }
    }
}
