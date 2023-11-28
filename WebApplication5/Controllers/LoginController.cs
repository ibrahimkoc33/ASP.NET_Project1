using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace WebApplication5.Controllers
{
	public class LoginController : Controller
	{

		public IActionResult Index()
		{
			ClaimsPrincipal claimUser = HttpContext.User;

			if(claimUser.Identity.IsAuthenticated)
			{
				return RedirectToAction("Index", "Home");
			}
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Index(User u)
		{
			using var c = new Context();
			var datavalue = c.Users.FirstOrDefault(x => x.Username == u.Username && x.Password == u.Password);
			if (datavalue != null)
			{
				var claims = new List<Claim>
				{
					new Claim(ClaimTypes.Name,u.Username),
				};
				var useridentity = new ClaimsIdentity(claims, "rastgele verilen değer");
				ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
				await HttpContext.SignInAsync(principal);
				
				return RedirectToAction("Index", "Home");
			}
			else
			{
				ViewData["ValidateMessage"] = "USER NOT FOUND";
				return View();
			}

		}
	}
}
