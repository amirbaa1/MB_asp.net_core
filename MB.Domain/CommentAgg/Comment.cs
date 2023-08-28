using System;
using MB.Domain.ArtAgg;

namespace MB.Domain.CommentAgg
{
	public class Comment
	{
		public int Id { get; private set; }
		public string Name { get; private set; }
		public string Email { get; private set; }
		public string Message { get; private set; }
		public int Status { get; private set; } // new=0,confrimed = 1 , canceled = 2,
		public DateTime SendMessage { get; private set; }
		public int ArtId { get; private set; }
		public Art art { get; private set; }

		protected Comment() {} 

		public Comment(string name, string email, string message, int artId)
		{
			Name = name;
			Email = email;
			Message = message;
			ArtId = artId;
			SendMessage = DateTime.UtcNow;
			Status = Statuses.New;
		}

	}
}

