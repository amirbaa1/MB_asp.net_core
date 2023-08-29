using System;
namespace MB.Applications.Contracts.Comment
{
	public class CommentViewModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Message { get; set; }
		public string SendMessage { get; set; }
		public int Status { get; set; }
		public int ArtId { get; set; }
		public string Art { get; set; }
    }
}

