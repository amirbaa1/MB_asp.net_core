

namespace MB.Applications.Contracts.Art
{
    public interface IArtApplication
    {
        List<ArtViewModel> List();
        void Create(ArtCreate command);
        void Edit(ArtEdit command);
        ArtEdit Get(int id);
        void Delete(int id);
        void Activate(int id);

    }
}
