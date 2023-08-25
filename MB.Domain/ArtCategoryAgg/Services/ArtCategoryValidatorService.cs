using MB.Domain.ArtCategoryAgg.Exception;

namespace MB.Domain.ArtCategoryAgg.Services
{
    public class ArtCategoryValidatorService : IArtCategoryValidatorService
    {
        private readonly IArtCategoryRepository _artCategoryRepository;
        public ArtCategoryValidatorService(IArtCategoryRepository artCategoryRepository)
        {
            _artCategoryRepository = artCategoryRepository;
        }
        public void CheckRecoredIsTitle(string title)
        {
            if(_artCategoryRepository.CheckIsTitle(title))
                throw new DuplicatedRecordException("This record already exists in database.");
            
        }
    }
}

