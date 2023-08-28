
using MB.infrasturctureQuery;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentation.MVCCore.Pages
{
	public class ArtDetailsModel : PageModel
    {
        public ArtQueryView artQueryView { get; set; }
        private readonly IArtQuery _artQuery;
        public ArtDetailsModel(IArtQuery artQuery)
        {
            _artQuery = artQuery;
        }
        public IActionResult OnGet(int id)
        {
            artQueryView = _artQuery.GetArt(id);
            if(artQueryView.IsDelete == true)
            {
                return NotFound(); //TODO: bug why it is id IsDelete in ture that is running .
            }
            return Page();
        }
    }
}
