using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MovieApiController : Controller
	{
		MovieManager mm = new MovieManager(new EFMovieRepository());
		[HttpGet("api/movies")]
		public IActionResult GetMovies()
		{
			var movies = mm.ListAll();
			return Ok(movies);
		}

		[HttpGet("api/movies/{id}")]
		public IActionResult GetMovie(int id)
		{
			var movie = mm.GetById(id);
			if (movie == null)
			{
				return NotFound();
			}
			return Ok(movie);
		}
		[HttpPost]
		public IActionResult AddMovie(Movie movie)
		{
			using var c = new Context();
			c.Add(movie);
			c.SaveChanges();
			return Ok();
		}
	}
}
