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
		[HttpPut("Update Movie")]
		public IActionResult UpdateMovie(Movie movie)
		{
			using var c = new Context();
			var m = c.Movies.Find(movie.Id);
			m.Overview=movie.Overview;
			m.Star=movie.Star;
			m.Director=movie.Director;
			m.Cast=movie.Cast;
			m.Date=movie.Date;
			//devamı var
			c.Update(movie);
			c.SaveChanges();
			return Ok();
		}

		[HttpDelete("Remove Movie")]
		public IActionResult RemoveMovie(int id)
		{
			using var c = new Context();
			var movie = c.Movies.Find(id);
			c.Remove(movie);
			c.SaveChanges();
			return Ok();
		}
	}
}
