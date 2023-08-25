
using MB.Domain.ArtAgg;

namespace MB.Domain.ArtCategoryAgg
{
    public class ArtCategory
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public bool IsDeleted { get; private set; }
        public DateTime CreateDate { get; private set; }

    public ICollection<Art> arts { get; private set; }  
        public ArtCategory(string title) 
        {
            GuardEmptyTitle(title);
/*            validatorService.CheckRecoredIsTitle(title);
*/            Title = title;
            IsDeleted = false;
            CreateDate = DateTime.UtcNow;
            arts = new List<Art>();
        
        }
        public void Rename(string title)
        {
            GuardEmptyTitle(title);
            Title = title;
        }
        public void Delete ()
        {
            IsDeleted = true;
        }
        public void Activate()
        {
            IsDeleted = false;
        }
        public void GuardEmptyTitle(string title)
        {
            if(string.IsNullOrWhiteSpace(title))
                throw new ArgumentNullException();
        }
    }
}
