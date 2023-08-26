using System;
namespace MB.Applications.Contracts.Art
{
	public class ArtCreate
	{
		public string Title { get; set; }
		public string ShortText { get; set; }
		public string Image { get; set; }
		public string Context { get; set; }
		public int ArtCategoryId { get; set; }
	}
}

