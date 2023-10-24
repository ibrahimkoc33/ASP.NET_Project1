using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
	public class CelebritiesController : Controller
	{
		CelebritiesManager cm = new CelebritiesManager(new EFCelebritiesRepository());
		public IActionResult Index()
		{
			var values = cm.ListAll();
			return View(values);
		}
		public IActionResult CelebritiesList()
		{
			var values = cm.ListAll();
			return View(values);
		}public IActionResult CelebritiesDetails(int id)
		{
			var values = cm.GetCelebritiesById(id);
			return View(values);
		}
	}
}
