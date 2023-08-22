using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Domain.ArtCategoryAgg
{
    public interface IArtCategoryRepository
    {
        void Creat(ArtCategory entity);
        List<ArtCategory> GetAll();

        //void Update(ArtCategory entity);

    }
}
