using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}