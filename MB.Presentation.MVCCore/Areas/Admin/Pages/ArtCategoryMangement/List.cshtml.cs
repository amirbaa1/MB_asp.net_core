
using MB.Applications.Contracts.ArtCategory;
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
            ArtCategoryViewModels = _artCategoryApplication.List();
        }
    }
}
