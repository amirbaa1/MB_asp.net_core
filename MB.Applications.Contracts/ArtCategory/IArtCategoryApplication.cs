namespace MB.Applications.Contracts.ArtCategory
{
    public interface IArtCategoryApplication
    {
        List<ArtCategoryViewModel> List_See_Web();
        void Create(ArtCategoryCreate command);
        void Rename(ArtCategoryRename command);
        ArtCategoryRename Get(long id);
        void Delete(long id);
        void Activate(long id);
        void Remove(long id);
    }
}