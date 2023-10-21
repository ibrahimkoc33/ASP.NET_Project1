using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IMovieService
	{
		void MovieAdd(Movie movie);
		void MovieRemove(Movie movie);
		void MovieUpdate(Movie movie);
		List<Movie> ListAll();

		Movie GetById(int id);
	}
}
