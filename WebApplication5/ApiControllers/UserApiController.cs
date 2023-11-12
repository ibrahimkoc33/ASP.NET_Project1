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
	public class UserApiController : Controller
	{
		UserManager um = new UserManager(new EFUserRepository());
		[HttpGet("Get Users")]
		public IActionResult GetUsers()
		{
			var users = um.ListAll();
			return Ok(users);
		}
		[HttpGet("Get User By Id")]
		public IActionResult GetUser(int id)
		{
			var user = um.GetById(id);
			if (user == null)
			{
				return NotFound();
			}
			return Ok(user);
		}
		[HttpPost("Add User")]
		public IActionResult AddUser(User user)
		{
			using var c = new Context();
			c.Add(user);
			c.SaveChanges();
			return Ok();
		}

		[HttpPost("Remove User")]
		public IActionResult RemoveUser(User user)
		{
			using var c = new Context();
			c.Remove(user);
			c.SaveChanges();
			return Ok();
		}
	}
}
