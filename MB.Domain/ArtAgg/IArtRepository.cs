using MB.Applications.Contracts.Art;
namespace MB.Domain.ArtAgg
{
    public interface IArtRepository 
    {
        List<ArtViewModel> GetAll();
        void Create(Art command);
        Art Get(int id);
        void Save();
        bool Exists(string title);
        void Remove(Art command);
    }
}

