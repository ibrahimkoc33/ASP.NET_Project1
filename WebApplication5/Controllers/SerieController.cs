using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
    public class SerieController : Controller
    {
        SerieManager cm = new SerieManager(new EFSerieRepository());
        public IActionResult Index()
        {
            var values = cm.ListAll();
            return View(values);
        }
    }
}
