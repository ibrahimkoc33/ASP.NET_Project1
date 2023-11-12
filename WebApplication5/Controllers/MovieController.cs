using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
	//[ApiController]
	//[Route("[controller]")]
	public class MovieController : Controller
	{
		MovieManager mm = new MovieManager(new EFMovieRepository());
		public IActionResult Index()
		{
			var values = mm.GetMovieByCategory();
			return View(values);
		}
		public IActionResult MovieDetails(int id)
		{
			ViewBag.i = id;
			var values = mm.GetMovieById(id);
			return View(values);
		}
		public IActionResult MovieList()
		{
			var values = mm.GetMovieByCategory();
			return View(values);
		}
		public IActionResult MovieListByGrid()
		{
			var values = mm.GetMovieByCategory();
			return View(values);
		}

		//[HttpGet("api/movies")]
		public IActionResult GetMovies()
		{
			var movies = mm.GetMovieByCategory();
			return Ok(movies);
		}

		//[HttpGet("api/movies/{id}")]
		public IActionResult GetMovie(int id)
		{
			var movie = mm.GetMovieById(id);
			if (movie == null)
			{
				return NotFound();
			}
			return Ok(movie);
		}
	}
}
