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
		[HttpGet("Get Movies")]
		public IActionResult GetMovies()
		{
			var movies = mm.ListAll();
			return Ok(movies);
		}

		[HttpGet("Get Movie By Id")]
		public IActionResult GetMovie(int id)
		{
			var movie = mm.GetById(id);
			if (movie == null)
			{
				return NotFound();
			}
			return Ok(movie);
		}
		[HttpPost("Add Movie")]
		public IActionResult AddMovie(Movie movie)
		{
			using var c = new Context();
			c.Add(movie);
			c.SaveChanges();
			return Ok();
		}

		[HttpPost("Remove Movie")]
		public IActionResult RemoveMovie(Movie movie)
		{
			using var c = new Context();
			c.Remove(movie);
			c.SaveChanges();
			return Ok();
		}
	}
}
