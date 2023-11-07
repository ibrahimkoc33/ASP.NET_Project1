using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
	public class RegisterController : Controller
	{
		UserManager um = new UserManager(new EFUserRepository());
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(User u)
		{
			u.IsActive = true;
			um.UserAdd(u);
			return RedirectToAction("Index", "Home");
		}
	}
}
