using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class MovieManager : IMovieService
	{
		IMovie _movie;

		public MovieManager(IMovie movie)
		{
			_movie = movie;
		}

		public void MovieAdd(Movie movie)
		{
			_movie.Add(movie);
		}

		public void MovieRemove(Movie movie)
		{
			_movie.Delete(movie);
		}

		public void MovieUpdate(Movie movie)
		{
			_movie.Update(movie);
		}

		public Movie GetById(int id)
		{
			return _movie.GetById(id);
		}

		public List<Movie> ListAll()
		{
			return _movie.ListAll();
		}

        public List<Movie> GetMovieByCategory()
        {
			return _movie.GetByCategory();
        }
    }
}
