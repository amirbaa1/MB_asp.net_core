using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Domain.ArtCategoryAgg.Services
{
    public interface IArtCategoryValidatorService
    {
        void CheckRecoredIsTitle(string title);
    }
}

