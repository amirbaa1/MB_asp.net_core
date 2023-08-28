using MB.Applications.Contracts.Comment;
using MB.Domain.CommentAgg;

namespace MB.Application
{
	public class CommentApplication :ICommentApp
	{
		private readonly ICommentRepository _commentRepository;
		public CommentApplication(ICommentRepository commentRepository)
		{
			_commentRepository = commentRepository;
		}

	}
}

