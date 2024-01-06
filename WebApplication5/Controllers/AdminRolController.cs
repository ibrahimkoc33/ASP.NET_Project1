using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
	public class AdminRolController : Controller
	{
		private readonly RoleManager<AppRole> _roleMenager;

        public AdminRolController(RoleManager<AppRole> roleMenager)
        {
            _roleMenager = roleMenager;
        }

        public IActionResult Index()
		{
			var values = _roleMenager.Roles.ToList();
			return View(values);
		}
		[HttpGet]
		public IActionResult AddRole() 
		{
			return View();
		}

        [HttpPost]
        public async Task<IActionResult> AddRole(RoleViewModel model)
        {
			if(ModelState.IsValid)
			{
				AppRole role = new AppRole
				{
					Name = model.name
					
				};
				var result = await _roleMenager.CreateAsync(role);
				if(result.Succeeded)
				{
					return RedirectToAction("Index","AdminRol");
				}
				foreach(var item in result.Errors)
				{
					ModelState.AddModelError("", item.Description);
				}
			}
            return View(model);
        }
    }
}
