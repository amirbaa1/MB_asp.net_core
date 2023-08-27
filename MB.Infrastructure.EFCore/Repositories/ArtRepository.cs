using System;
using System.Globalization;
using MB.Applications.Contracts.Art;
using MB.Domain.ArtAgg;
using Microsoft.EntityFrameworkCore;

namespace MB.Infrastructure.EFCore.Repositories
{

    public class ArtRepository : IArtRepository
    {
        private readonly MBContext _context;
        public ArtRepository(MBContext context)
        {
            _context = context;
        }

        public void Create(Art command)
        {
            _context.arts.Add(command);
            Save();
      
        }

        public Art Get(int id)
        {
            return _context.arts.FirstOrDefault(x => x.Id == id);
        }

        public List<ArtViewModel> GetAll()
        {
            return _context.arts.Include(x => x.ArtCategory).Select(x => new ArtViewModel
            {
                Id = x.Id,
                Title = x.Title,
                ArtCategory = x.ArtCategory.Title,
                IsDelete = x.IsDelete,
                CreateTime = x.CreatTime.ToString(CultureInfo.InstalledUICulture),

            }).ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public bool Exists(string title)
        {
            return _context.arts.Any(x => x.Title == title);
        }
    }
}
