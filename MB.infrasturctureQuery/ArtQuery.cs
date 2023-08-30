using System;
using System.Globalization;
using MB.Domain.CommentAgg;
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
            return _context.arts.Include(x => x.ArtCategories).Include(x => x.Comments).Select(x => new ArtQueryView
            {
                Id = x.Id,
                Title = x.Title,
                ShortText = x.ShortText,
                CreateTime = x.CreatTime.ToString(CultureInfo.InvariantCulture),
                Image = x.Image,
                ArtCategory = x.ArtCategories.Title,
                IsDelete = x.IsDelete,
                CommnetCount = x.Comments.Count(x => x.Status == Statuses.Confrimed),

            }).ToList();
        }
        // opne wiht id post detils art
        public ArtQueryView GetArt(int id)
        {
            return _context.arts.Include(x => x.ArtCategories).Include(x=>x.Comments).Select(x => new ArtQueryView
            {
                Id = x.Id,
                Title = x.Title,
                ShortText = x.ShortText,
                CreateTime = x.CreatTime.ToString(CultureInfo.InvariantCulture),
                Image = x.Image,
                ArtCategory = x.ArtCategories.Title,
                Context = x.Context,
                CommnetCount=x.Comments.Count(x=>x.Status == Statuses.Confrimed),
                CommnetQureyViews = MapComments(x.Comments.Where(x=>x.Status == Statuses.Confrimed)),
            }).FirstOrDefault(x => x.Id == id);
        }
        //comment in post art
        private static List<CommnetQureyView> MapComments(IEnumerable<Comment> enumerable)
        {
            var result = new List<CommnetQureyView>();
            foreach (var c in enumerable)
            {
                result.Add(new CommnetQureyView
                {
                    Email = c.Email,
                    Name = c.Name,
                    Message = c.Message,
                    SandMessage = c.SendMessage.ToString(),
                });
            }
            return result;
        }

    }
}

