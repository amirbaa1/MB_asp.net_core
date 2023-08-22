using MB.Applications.Contracts.ArtCategory;
using MB.Domain.ArtCategoryAgg;

namespace MB.Application
{
    public class ArtCategoryApplication : IArtCategoryApplication
    {
        private readonly IArtCategoryRepository _artCategoryRepository;
        public ArtCategoryApplication(IArtCategoryRepository artCategoryRepository)
        {
            _artCategoryRepository = artCategoryRepository;
        }
        public List<ArtCategoryViewModel> List()
        {
            var artcategories = _artCategoryRepository.GetAll();
            var result = new List<ArtCategoryViewModel>();
            foreach(var  artcategory in artcategories) 
            {
                result.Add(new ArtCategoryViewModel
                {
                    Id = artcategory.Id,
                    Title = artcategory.Title,
                    IsDelete = artcategory.IsDeleted,
                    CreateDate = artcategory.CreateDate.ToString(System.Globalization.CultureInfo.InvariantCulture),
                });
            }
        }
    }
}