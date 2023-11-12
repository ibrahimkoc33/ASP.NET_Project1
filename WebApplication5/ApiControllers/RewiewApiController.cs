using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.ApiControllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RewiewApiController : ControllerBase
	{
		RewiewManager rm = new RewiewManager(new EFRewiewRepository());
		[HttpGet("api/rewiews")]
		public IActionResult GetRewiews()
		{
			var rewiews = rm.ListAll();
			return Ok(rewiews);
		}
		[HttpGet("api/users/{id}")]
		public IActionResult GetRewiew(int id)
		{
			var rewiew = rm.GetById(id);
			if (rewiew == null)
			{
				return NotFound();
			}
			return Ok(rewiew);
		}
	}
}
