using System;
namespace MB.Applications.Contracts.Comment
{
	public interface ICommentApp
	{
		void Add(AddComment comment);
		List<CommentViewModel> List();
		void Confrimed(int id);
		void Cancel(int id);
	}
}

