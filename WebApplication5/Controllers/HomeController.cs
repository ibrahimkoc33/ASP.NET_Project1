using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
	[Authorize]
	public class HomeController : Controller
    {
		private readonly ILogger<HomeController> _logger;
		private readonly SignInManager<AppUser> _signInManager; // SignInManager'ı ekledik

		public HomeController(ILogger<HomeController> logger, SignInManager<AppUser> signInManager)
		{
			_logger = logger;
			_signInManager = signInManager; // SignInManager'ı enjekte ettik
		}

		MovieManager mm = new MovieManager(new EFMovieRepository());
        UserManager um = new UserManager(new EFUserRepository());
		
		public IActionResult Index()
		{
			var values = mm.GetMovieByCategory();
			return View(values);
		}
		public IActionResult MovieDetails(int id)
		{
			var values = mm.GetMovieById(id);
			return View(values);
		}

		public IActionResult Privacy()
        {
            return View();
        }
		public async Task<IActionResult> LogOut()
		{
			//await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
			await _signInManager.SignOutAsync();
			return RedirectToAction("Login", "Account");
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}