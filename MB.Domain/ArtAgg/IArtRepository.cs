using MB.Applications.Contracts.Art;
namespace MB.Domain.ArtAgg
{
    public interface IArtRepository 
    {
        List<ArtViewModel> GetAll();
        void Create(Art command);
        void Save();
    }
}

