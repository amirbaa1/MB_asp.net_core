using MB.Applications.Contracts.ArtCategory;
using MB.Domain.ArtCategoryAgg;
using MB.Domain.ArtCategoryAgg.Exception;
using MB.Domain.ArtCategoryAgg.Services;

namespace MB.Application
{
    public class ArtCategoryApplication : IArtCategoryApplication
    {
        private readonly IArtCategoryRepository _artCategoryRepository;
        private readonly IArtCategoryValidatorService _artCategoryValidatorService;
        public ArtCategoryApplication(IArtCategoryRepository artCategoryRepository, IArtCategoryValidatorService artCategoryValidatorService)
        {
            _artCategoryRepository = artCategoryRepository;
            _artCategoryValidatorService = artCategoryValidatorService;

        }
        public bool IsTitleDuplicate(string title)
        {
            return _artCategoryRepository.CheckIsTitle(title);
        }
        public void Create(ArtCategoryCreate command)
        {
            //if (IsTitleDuplicate(command.Title))
            //{
            //    throw new DuplicatedRecordException("This record already exists in the database.");
            //}
            var artCategoryAdd = new ArtCategory(command.Title,_artCategoryValidatorService);
            //_artCategoryValidatorService.CheckRecoredIsTitle(command.Title);

            _artCategoryRepository.Creat(artCategoryAdd);

        }

        public List<ArtCategoryViewModel> List_See_Web()
        {
            var artcategories = _artCategoryRepository.GetAll();
            var result = new List<ArtCategoryViewModel>();
            foreach (var artcategory in artcategories)
            {
                result.Add(new ArtCategoryViewModel
                {
                    Id = artcategory.Id,
                    Title = artcategory.Title,
                    IsDelete = artcategory.IsDeleted,
                    CreateDate = artcategory.CreateDate,
                });
            }
            return result;
        }

        public void Rename(ArtCategoryRename command)
        {
            var artcategory = _artCategoryRepository.Get(command.Id);
            artcategory.Rename(command.Title);
            _artCategoryRepository.Save();
        }
        public ArtCategoryRename Get(long id)
        {
            var artcategory_old = _artCategoryRepository.Get(id);
            return new ArtCategoryRename
            {
                Id = artcategory_old.Id,
                Title = artcategory_old.Title,
            };
        }

        public void Delete(long id)
        {
            var artcategory = _artCategoryRepository.Get(id);
            artcategory.Delete();
            _artCategoryRepository.Save();
        }

        public void Activate(long id)
        {
            var artcategory = _artCategoryRepository.Get(id);
            artcategory.Activate();
            _artCategoryRepository.Save();
        }

        public void Remove(long id)
        {
            var artcategory = _artCategoryRepository.Get(id);
            _artCategoryRepository.Remove(artcategory);
            _artCategoryRepository.Save();
        }
    }
}