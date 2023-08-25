using MB.Domain.ArtAgg;


namespace MB.Infrastructure.EFCore.Repositories
{
   
    public class ArtRepository :IArtRepository
    {
        private readonly MBContext _context;
        public ArtRepository(MBContext context)
        {
            _context = context;
        }
    }
}
