using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.ViewComponents.Rewiew
{
    public class RewiewListByMovie:ViewComponent
    {
        RewiewManager rm = new RewiewManager(new EFRewiewRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = rm.ListAll(id);
            return View(values);
        }
    }
}
