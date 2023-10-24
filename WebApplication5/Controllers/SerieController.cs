using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
    public class SerieController : Controller
    {
        SerieManager sm = new SerieManager(new EFSerieRepository());
        public IActionResult Index()
        {
            var values = sm.GetSerieByCategory();
            return View(values);
        }
		public IActionResult SerieDetails(int id)
		{
			var values = sm.GetSerieById(id);
			return View(values);
		}
		public IActionResult SerieList()
		{
			var values = sm.GetSerieByCategory();
			return View(values);
		}
		public IActionResult SerieListByGrid()
		{
			var values = sm.GetSerieByCategory();
			return View(values);
		}
	}
}
