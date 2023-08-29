
using MB.Applications.Contracts.Comment;
using MB.infrasturctureQuery;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentation.MVCCore.Pages
{
	public class ArtDetailsModel : PageModel
    {
        public ArtQueryView artQueryView { get; set; }
        private readonly IArtQuery _artQuery;
        private readonly ICommentApp _commentApp;
        public ArtDetailsModel(IArtQuery artQuery, ICommentApp commentApp)
        {
            _artQuery = artQuery;
            _commentApp = commentApp;
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
        public IActionResult OnPost(AddComment addComment)
        {
            _commentApp.Add(addComment);
            return RedirectToPage("./ArtDetails", new { id = addComment.ArtId });
        }
    }
}
