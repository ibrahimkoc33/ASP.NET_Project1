using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
    public class MovieController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
