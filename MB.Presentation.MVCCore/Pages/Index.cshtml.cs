using MB.infrasturctureQuery;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentation.MVCCore.Pages;

public class IndexModel : PageModel
{
    public List<ArtQueryView> ArtViews { get; set; }
    private readonly IArtQuery _artQuery;
    public IndexModel(IArtQuery artQuery)
    {
        _artQuery = artQuery;
    }
    public void OnGet()
    {
        ArtViews = _artQuery.GetArt().Where(x => x.IsDelete == false).ToList();
    }
}

