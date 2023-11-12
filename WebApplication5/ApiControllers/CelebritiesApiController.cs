using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CelebritiesApiController : Controller
	{
		CelebritiesManager um = new CelebritiesManager(new EFCelebritiesRepository());
		[HttpGet("Get Celebrities")]
		public IActionResult GetCelebrities()
		{
			var celebrities = um.ListAll();
			return Ok(celebrities);
		}
		[HttpGet("Get Celebritity By Id")]
		public IActionResult GetCelebritity(int id)
		{
			var celebrities = um.GetById(id);
			if (celebrities == null)
			{
				return NotFound();
			}
			return Ok(celebrities);
		}
		[HttpPost("Add Celebritity")]
		public IActionResult AddCelebrities(Celebrities celebrities)
		{
			using var c = new Context();
			c.Add(celebrities);
			c.SaveChanges();
			return Ok();
		}
		[HttpPut("Update Celebritity")]
		public IActionResult UpdateCelebrities(Celebrities celebrities)
		{
			using var c = new Context();
			var celeb = c.Celebrities.Find(celebrities.Id);
			celeb.Series = celebrities.Series;
			celeb.Height = celebrities.Height;
			celeb.Age = celebrities.Age;
			celeb.Movies = celebrities.Movies;
			//devamı var
			c.Update(celebrities);
			c.SaveChanges();
			return Ok();

		}

		[HttpDelete("Remove Celebritity")]
		public IActionResult CelebritiesUser(int id)
		{
			using var c = new Context();
			var celebrities = c.Celebrities.Find(id);
			c.Remove(celebrities);
			c.SaveChanges();
			return Ok();
		}
	}
}
