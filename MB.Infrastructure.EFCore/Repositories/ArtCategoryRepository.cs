using MB.Domain.ArtCategoryAgg;

namespace MB.Infrastructure.EFCore.Repositories
{
    public class ArtCategoryRepository : IArtCategoryRepository
    {
       private readonly MBContext _context;
        
        public ArtCategoryRepository(MBContext context)
        {
            _context = context;
        }

        public bool CheckIsTitle(string title)
        {
            return _context.ArtCategories.Any(c => c.Title == title);
        }

        public void Creat(ArtCategory entity)
        {
            _context.ArtCategories.Add(entity);
            Save();
        }

        public ArtCategory Get(long id)
        {
            return _context.ArtCategories.FirstOrDefault(c => c.Id == id);
        }

        public List<ArtCategory> GetAll()
        {
            return _context.ArtCategories.ToList();
        }

        public void Save()
        {
             _context.SaveChanges();
        }
    }
}