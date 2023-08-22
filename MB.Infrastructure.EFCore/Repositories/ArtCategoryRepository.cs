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

        public void Creat(ArtCategory entity)
        {
            _context.ArtCategories.Add(entity);
            _context.SaveChanges();
        }

        public List<ArtCategory> GetAll()
        {
            return _context.ArtCategories.ToList();
        }
    }
}