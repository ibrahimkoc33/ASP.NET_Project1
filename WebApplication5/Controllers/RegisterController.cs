using BusinessLayer.Concrete;
using BusinessLayer.Validation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
	public class RegisterController : Controller
	{
		UserManager um = new UserManager(new EFUserRepository());
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(User u)
		{
			UserValidator validationRules = new UserValidator();
			ValidationResult results = validationRules.Validate(u);
			if(results.IsValid)
			{
				u.IsActive = true;
				um.UserAdd(u);
				return RedirectToAction("Index", "Home");
			}
			else
			{
				foreach(var item in results.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			return View();
			
		}
	}
}
