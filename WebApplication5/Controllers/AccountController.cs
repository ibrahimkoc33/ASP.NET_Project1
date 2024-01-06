using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
	{
		private readonly SignInManager<AppUser> _signInManager;

        public AccountController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

		

        public IActionResult Login()
		{
			ClaimsPrincipal claimUser = HttpContext.User;

			if(claimUser.Identity.IsAuthenticated)
			{
				return RedirectToAction("Index", "Home");
			}
			return View();
		}


		[HttpPost]
		public async Task<IActionResult> Login(UserSignInViewModel p)
		{
			if (ModelState.IsValid)
			{
				var result = await _signInManager.PasswordSignInAsync(p.username, p.password, false, true);
				if (result.Succeeded)
				{
					return RedirectToAction("Index", "Home");
				}
				else
				{
					return RedirectToAction("Login", "Account");
				}
			}
			return View();
		}

		//[HttpPost]
		//public async Task<IActionResult> Index(User u)
		//{
		//	using var c = new Context();
		//	var datavalue = c.Users.FirstOrDefault(x => x.Username == u.Username && x.Password == u.Password);
		//	if (datavalue != null)
		//	{
		//		var claims = new List<Claim>
		//		{
		//			new Claim(ClaimTypes.Name,u.Username),
		//		};
		//		var useridentity = new ClaimsIdentity(claims, "rastgele verilen değer");
		//		ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
		//		await HttpContext.SignInAsync(principal);

		//		return RedirectToAction("Index", "Home");
		//	}
		//	else
		//	{
		//		ViewData["ValidateMessage"] = "USER NOT FOUND";
		//		return View();
		//	}

		//}
	}
}
