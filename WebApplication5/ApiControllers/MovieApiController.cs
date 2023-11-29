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
			m.Name = movie.Name;
			m.Genre = movie.Genre;
			m.Director = movie.Director;
			m.Scenarist = movie.Scenarist;
			m.Cast = movie.Cast;
			m.Image = movie.Image;
			m.Star = movie.Star;
			m.RunTime = movie.RunTime;
			m.Overview=movie.Overview;
			m.Date=movie.Date;
			m.Rewiews = movie.Rewiews;
			m.CategoryId = movie.CategoryId;
			m.Category = movie.Category;
			if (movie == null)
			{
				return NotFound();
			}
			c.Update(m);
			c.SaveChanges();
			return Ok();
		}

		[HttpDelete("Remove Movie")]
		public IActionResult RemoveMovie(int id)
		{
			using var c = new Context();
			var movie = c.Movies.Find(id);
			if (movie == null)
			{
				return NotFound();
			}
			c.Remove(movie);
			c.SaveChanges();
			return Ok();
		}
	}
}
