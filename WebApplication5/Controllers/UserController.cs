using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApplication5.Controllers
{
	public class UserController : Controller
	{
		UserManager um = new UserManager(new EFUserRepository());
		public IActionResult Index()
		{
			return View();
		}
	}
}
