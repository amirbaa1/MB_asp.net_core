using MB.Applications.Contracts.Comment;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentation.MVCCore.Areas.Admin.Pages.CommnetManagement
{
    public class ListModel : PageModel
    {
        private readonly ICommentApp _commentApp;
        public List<CommentViewModel> comment { get; set; }
        public ListModel(ICommentApp commentApp)
        {
            _commentApp = commentApp;
        }

        public void OnGet()
        {
            comment = _commentApp.List();
        }
        public RedirectToPageResult OnPostConfrimed(int id) 
        {
            _commentApp.Confrimed(id);
            return RedirectToPage("./list");

        }
        public RedirectToPageResult OnPostCanseled(int id)
        {
            _commentApp.Cancel(id);
            return RedirectToPage("./list");
        }
    }
}
