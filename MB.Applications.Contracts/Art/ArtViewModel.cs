using System;
namespace MB.Applications.Contracts.Art
{
	public class ArtViewModel
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string ShortText { get; set; }
		public string ArtCategory { get; set; }
        public string Context { get; set; }
        public bool IsDelete { get; set; }
		public string CreateTime { get; set; }
	}
}

