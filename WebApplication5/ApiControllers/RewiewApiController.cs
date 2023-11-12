using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.ApiControllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RewiewApiController : ControllerBase
	{
		RewiewManager rm = new RewiewManager(new EFRewiewRepository());
		[HttpGet("Get Rewiews")]
		public IActionResult GetRewiews()
		{
			var rewiews = rm.ListAll();
			return Ok(rewiews);
		}
		[HttpGet("Get Rewiew By Id")]
		public IActionResult GetRewiew(int id)
		{
			var rewiew = rm.GetById(id);
			if (rewiew == null)
			{
				return NotFound();
			}
			return Ok(rewiew);
		}
		[HttpPost("Add Rewiew")]
		public IActionResult AddRewiew(Rewiew rewiew)
		{
			using var c = new Context();
			c.Add(rewiew);
			c.SaveChanges();
			return Ok();
		}

		[HttpPost("Remove Rewiew")]
		public IActionResult RemoveRewiew(Rewiew rewiew)
		{
			using var c = new Context();
			c.Remove(rewiew);
			c.SaveChanges();
			return Ok();
		}
	}
}
