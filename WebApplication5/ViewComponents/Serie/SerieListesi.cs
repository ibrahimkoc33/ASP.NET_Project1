using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.ViewComponents.Serie
{
	public class SerieListesi:ViewComponent
	{
		SerieManager rm = new SerieManager(new EFSerieRepository());
		public IViewComponentResult Invoke()
		{
			var values = rm.ListAll();
			return View(values);
		}
	}
}
