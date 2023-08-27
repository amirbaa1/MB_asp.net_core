using MB.Domain.ArtCategoryAgg.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Domain.ArtAgg.Services
{
    
    public class ArtValidationService : IArtValidationService
    {
        private readonly IArtRepository _artRepository;
        public ArtValidationService(IArtRepository artRepository)
        {
            _artRepository = artRepository;
        }

        public void CheckRecoredIsTitle(string title)
        {
            if (_artRepository.Exists(title))
            {
                throw new DuplicatedRecordException();
            }
        }
    }
}
