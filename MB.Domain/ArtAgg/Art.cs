using System;
using MB.Domain.ArtCategoryAgg;
using static System.Net.Mime.MediaTypeNames;

namespace MB.Domain.ArtAgg
{
    public class Art
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public string ShortText { get; private set; }
        public string Image { get; private set; }
        public string Context { get; private set; }
        public bool IsDelete { get; private set; }
        public DateTime CreatTime { get; private set; }
        public int ArtCategoryId { get; private set; }
        public ArtCategory ArtCategory { get; private set; }

        protected Art()
        {

        }
        public Art(string title, string shorttext, string image, string context, int artCategoryId)
        {
            Title = title;
            ShortText = shorttext;
            Image = image;
            Context = context;
            ArtCategoryId = artCategoryId;
            CreatTime = DateTime.UtcNow;
        }

    }
}
