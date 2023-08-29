using System;
using MB.Domain.ArtCategoryAgg;
using MB.Domain.CommentAgg;
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
        public ArtCategory ArtCategories { get; private set; }
        public ICollection<Comment> Comments { get; set; }

        protected Art()
        {

        }
        public Art(string title, string shorttext, string image, string context, int artCategoryId)
        {
            validata(title, artCategoryId);
            Title = title;
            ShortText = shorttext;
            Image = image;
            Context = context;
            ArtCategoryId = artCategoryId;
            IsDelete = false;
            CreatTime = DateTime.UtcNow;
/*            Comments = new List<Comment>();     
*/        }

        public void Edit(string title, string shorttext, string image, string context, int artCategoryId)
        {
            validata(title, artCategoryId);
            Title = title;
            ShortText = shorttext;
            Image = image;
            Context = context;
            ArtCategoryId = artCategoryId;
        }

        public void Delete()
        {
            this.IsDelete = true;
        }
        public void Activate()
        {
            this.IsDelete = false;
        }

        private static void validata(string title,int artcategoryId)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentNullException();
            if (artcategoryId == 0)
                throw new ArgumentOutOfRangeException();
        }
    }
}
