
namespace MB.Domain.ArtCategoryAgg
{
    public interface IArtCategoryRepository
    {
        void Creat(ArtCategory entity);
        List<ArtCategory> GetAll();
        ArtCategory Get(long id);
        void Save();
        bool CheckIsTitle(string title);
        void Remove(ArtCategory artCategory);
    }
}
