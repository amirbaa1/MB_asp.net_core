using MB.Applications.Contracts.Comment;
using MB.Domain.CommentAgg;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace MB.Infrastructure.EFCore.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly MBContext _context;
        public CommentRepository(MBContext context)
        {
            _context = context;
        }

        public void CreateAndSave(Comment e)
        {
            _context.comments.Add(e);
            _context.SaveChanges();
        }

        public List<CommentViewModel> GetAll()
        {
            return _context.comments.Include(x=>x.art).Select(x=> new CommentViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Email = x.Email,
                Message = x.Message,
                SendMessage = x.SendMessage.ToString("yyyy-MM-dd HH:mm"),
                Art = x.art.Title,
                ArtId = x.art.Id,
                Status = x.Status,
                
            }).ToList();
        }

        public Comment GetId(int id)
        {
            return _context.comments.FirstOrDefault(x=>x.Id == id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
