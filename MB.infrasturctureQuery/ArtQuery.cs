using System;
using System.Globalization;
using MB.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;

namespace MB.infrasturctureQuery
{
    public class ArtQuery : IArtQuery
    {
        private readonly MBContext _context;
        public ArtQuery(MBContext context)
        {
            _context = context;
        }
        public List<ArtQueryView> GetArt()
        {
            return _context.arts.Include(x => x.ArtCategories).Select(x => new ArtQueryView
            {
                Id = x.Id,
                Title = x.Title,
                ShortText = x.ShortText,
                CreateTime = x.CreatTime.ToString(CultureInfo.InvariantCulture),
                Image = x.Image,
                ArtCategory = x.ArtCategories.Title,
                IsDelete = x.IsDelete

            }).ToList();
        }

        public ArtQueryView GetArt(int id)
        {
            return _context.arts.Include(x => x.ArtCategories).Select(x => new ArtQueryView
            {
                Id = x.Id,
                Title = x.Title,
                ShortText = x.ShortText,
                CreateTime = x.CreatTime.ToString(CultureInfo.InvariantCulture),
                Image = x.Image,
                ArtCategory = x.ArtCategories.Title,
                Context = x.Context
            }).FirstOrDefault(x => x.Id == id);
        }
    }
}

