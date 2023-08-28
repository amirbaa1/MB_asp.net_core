using System;
namespace MB.infrasturctureQuery
{
	public interface IArtQuery
	{
		List<ArtQueryView> GetArt();
		ArtQueryView GetArt(int id);

	}
}

