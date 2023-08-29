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

        public void Add(AddComment command)
        {
            var comment = new Comment(command.Name, command.Email, command.Message, command.ArtId);
            _commentRepository.CreateAndSave(comment);
        }

        public List<CommentViewModel> List()
        { 
            return _commentRepository.GetAll();
        }

        public void Cancel(int id)
        {
            var commnet =  _commentRepository.GetId(id);
            commnet.Canceled();
            _commentRepository.Save();
        }

        public void Confrimed(int id)
        {
            var commnet = _commentRepository.GetId(id);
            commnet.Confrimed();
            _commentRepository.Save();
        }

    }
}
