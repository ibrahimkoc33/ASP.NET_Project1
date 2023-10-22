using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
	public class MovieController : Controller
	{
		MovieManager cm = new MovieManager(new EFMovieRepository());
		public IActionResult Index()
		{
			var values = cm.GetMovieByCategory();
			return View(values);
		}
	}
}
