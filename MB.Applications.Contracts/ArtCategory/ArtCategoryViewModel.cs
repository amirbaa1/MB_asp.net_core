
namespace MB.Applications.Contracts.ArtCategory
{
    public class ArtCategoryViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsDelete { get; set; }
        public DateTime CreateDate { get; set; }
        //public ArtCategoryViewModel()
        //{
        //    IsDelete = false;
        //    CreateDate = DateTime.Now;
        //}

    }
}
