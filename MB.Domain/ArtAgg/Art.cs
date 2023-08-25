using MB.Domain.ArtCategoryAgg;

namespace MB.Domain.ArtAgg
{
    public class Art
    {
        public int Id { get;private set; } 
        public string Title { get;private set; }
        public string ShortDescription { get; private set; }
        public string Image { get; private set; }
        public string Context { get; private set; }
        public bool IsDelete { get; private set; }
        public DateTime CreatTime { get; private set; } 
        public long ArtCategoryId { get; private set; }
        public ArtCategory ArtCategory { get; private set; }
        protected Art(string title,string image,string shorDescription,string context,long artCategoryId) 
        {
            Title = title;
            ShortDescription = shorDescription;
            Image = image;
            Context = context;
            ArtCategoryId = artCategoryId;
            CreatTime = DateTime.Now;
        }
    }
}
