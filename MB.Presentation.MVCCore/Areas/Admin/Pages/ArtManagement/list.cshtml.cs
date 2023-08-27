
using MB.Applications.Contracts.Art;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentation.MVCCore.Areas.Admin.Pages.ArtManagement
{
	public class listModel : PageModel
    {
        public List<ArtViewModel> artViewModels { get; set; }
        private readonly IArtApplication _artApplication;
        public listModel(IArtApplication artApplication)
        {
            _artApplication = artApplication;
        }
        public void OnGet()
        {
            artViewModels = _artApplication.List().OrderBy(x=>x.Id).ToList();
        }
        public IActionResult OnPost()
        {
            return RedirectToPage("./list");
        }
        public IActionResult OnPostDelete(int id)
        {
            _artApplication.Delete(id);
            return RedirectToPage("./list");
        }
        public IActionResult OnPostActivate(int id)
        {
            _artApplication.Activate(id);
            return RedirectToPage("./list");
        }
    }
}
