

namespace MB.Applications.Contracts.Art
{
    public interface IArtApplication
    {
        List<ArtViewModel> List();
        void Create(ArtCreate command);
    }
}
