using MB.Applications.Contracts.Comment;
namespace MB.Domain.CommentAgg
{
	public interface ICommentRepository
	{
		void CreateAndSave(Comment e);
		List<CommentViewModel> GetAll();
		Comment GetId(int id);
		void Save();
	}
}

