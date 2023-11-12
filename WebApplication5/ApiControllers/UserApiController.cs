using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserApiController : Controller
	{
		UserManager um = new UserManager(new EFUserRepository());
		[HttpGet("api/users")]
		public IActionResult GetMovies()
		{
			var users = um.ListAll();
			return Ok(users);
		}
		[HttpGet("api/users/{id}")]
		public IActionResult GetMovie(int id)
		{
			var user = um.GetById(id);
			if (user == null)
			{
				return NotFound();
			}
			return Ok(user);
		}
	}
}
