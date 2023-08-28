
using MB.Domain.CommentAgg;

namespace MB.Infrastructure.EFCore.Repositories
{
	public class CommentRepository :ICommentRepository
	{
		private readonly MBContext _context;
		public CommentRepository(MBContext context)
		{
			_context = context;
		}

	}
}

