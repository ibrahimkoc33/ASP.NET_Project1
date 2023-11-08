using Microsoft.AspNetCore.Mvc;
using WebApplication5.Models;

namespace WebApplication5.ViewComponents
{
	public class RewiewList : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var rewiewValues = new List<UserRewiew>
			{
				new UserRewiew
				{
					ID = 1,
					Name = "Messi",

				},
				new UserRewiew
				{
					ID= 2,
					Name="Ronaldo"
				}
			};
			return View(rewiewValues);
		}
	}
}
