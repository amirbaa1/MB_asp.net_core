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

        public List<ArtViewModel> List()
        {
            return _artRepository.GetAll();
        }
        
    }
}
