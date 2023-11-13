using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
	public class ErrorPageController : Controller
	{
		public IActionResult Error(int code)
		{
			return View();
		}
	}
}
