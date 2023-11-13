using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
    public class RewiewController : Controller
    {
        RewiewManager rm = new RewiewManager(new EFRewiewRepository());
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialAddRewiew()
        {
            return PartialView();
        }
        public PartialViewResult RewiewList(int id)
        {
            var values = rm.ListAll(id);
            return PartialView(values);
        }
		[HttpPost]
		public IActionResult AddRewiewToMovie(Rewiew rewiew)
		{
			rewiew.Date = 2023;
			rewiew.MovieId = 1;
			rewiew.Writer = "iboo";
			rewiew.IsActive = true;
			rm.RewiewAdd(rewiew);
			return RedirectToAction("Index","Home");
		}

	}
}
