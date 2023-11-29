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
	public class CategoryApiController : Controller
	{
		CategoryManager um = new CategoryManager(new EFCategoryRepository());
		[HttpGet("Get Categories")]
		public IActionResult GetCategories()
		{
			var categories = um.ListAll();
			return Ok(categories);
		}
		[HttpGet("Get Category By Id {id}")]
		public IActionResult GetCategory(int id)
		{
			var category = um.GetById(id);
			if (category == null)
			{
				return NotFound();
			}
			return Ok(category);
		}
		[HttpPost("Add Category")]
		public IActionResult AddCategory(Category category)
		{
			using var c = new Context();
			c.Add(category);
			c.SaveChanges();
			return Ok();
		}
		[HttpPut("Update Category")]
		public IActionResult UpdateCategory(Category category)
		{
			using var c = new Context();
			var u = c.Categorys.Find(category.Id);
			u.Name = category.Name;
			u.color = category.color;
			u.Movies = category.Movies;
			if (category == null)
			{
				return NotFound();
			}
			c.Update(u);
			c.SaveChanges();
			return Ok();
		}

		[HttpDelete("Remove Category {id}")]
		public IActionResult RemoveCategory(int id)
		{
			using var c = new Context();
			var category = c.Categorys.Find(id);
			if (category == null)
			{
				return NotFound();
			}
			c.Remove(category);
			c.SaveChanges();
			return Ok();
		}


	}
}
