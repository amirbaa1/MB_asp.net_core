using MB.Applications.Contracts.Art;
using MB.Domain.ArtAgg;

namespace MB.Application
{
    public class ArtApplictaion : IArtApplication
    {
        private readonly IArtRepository _artRepository;

        public ArtApplictaion(IArtRepository artRepository)
        {
            _artRepository = artRepository;
        }

        public void Create(ArtCreate command)
        {
            var arts_create = new Art(command.Title, command.ShortText, command.Image, command.Context,
                command.ArtCategoryId);
            _artRepository.Create(arts_create);
        }

        public void Edit(ArtEdit command)
        {
            var arts = _artRepository.Get(command.Id);
            arts.Edit(command.Title, command.ShortText, command.Image, command.Context, command.ArtCategoryId);
            _artRepository.Save();

        }

        public ArtEdit Get(int id)
        {
            var art = _artRepository.Get(id);
            return new ArtEdit
            {
                Title = art.Title,
                Id = art.Id,
                Image = art.Image,
                ShortText = art.ShortText,
                Context = art.Context,
                ArtCategoryId = art.ArtCategoryId
            };
        }

        public List<ArtViewModel> List()
        {
            return _artRepository.GetAll();
        }

        public void Delete(int id)
        {
            var art = _artRepository.Get(id);
            art.Delete();
            _artRepository.Save();
        }

        public void Activate(int id)
        {
            var art = _artRepository.Get(id);
            art.Activate();
            _artRepository.Save();
        }
    }
}
