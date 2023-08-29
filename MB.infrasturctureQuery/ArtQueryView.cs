namespace MB.infrasturctureQuery;


public class ArtQueryView
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Image { get; set; }
    public string ShortText { get; set; }
    public string CreateTime { get; set; }
    public int ArtCategoryId { get; set; }
    public string ArtCategory { get; set; }
    public string Context { get; set; }
    public bool IsDelete { get; set; }
    public int CommnetCount { get; set; }
    public List<CommnetQureyView> CommnetQureyViews { get; set; }
}

