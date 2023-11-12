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
	public class SerieApiController : ControllerBase
	{
		SerieManager mm = new SerieManager(new EFSerieRepository());
		[HttpGet("Get Series")]
		public IActionResult GetSeries()
		{
			var series = mm.ListAll();
			return Ok(series);
		}

		[HttpGet("Get Serie By Id")]
		public IActionResult GetSerie(int id)
		{
			var serie = mm.GetById(id);
			if (serie == null)
			{
				return NotFound();
			}
			return Ok(serie);
		}
		[HttpPost("Add Serie")]
		public IActionResult AddSerie(Serie serie)
		{
			using var c = new Context();
			c.Add(serie);
			c.SaveChanges();
			return Ok();
		}
		[HttpPut("Update Serie")]
		public IActionResult UpdateSerie(Serie serie)
		{
			using var c = new Context();
			var m = c.Series.Find(serie.Id);
			m.Overview = serie.Overview;
			m.Star = serie.Star;
			m.Director = serie.Director;
			m.Cast = serie.Cast;
			m.Date = serie.Date;
			//devamı var
			c.Update(serie);
			c.SaveChanges();
			return Ok();
		}

		[HttpDelete("Remove Serie")]
		public IActionResult RemoveSerie(int id)
		{
			using var c = new Context();
			var serie = c.Series.Find(id);
			c.Remove(serie);
			c.SaveChanges();
			return Ok();
		}
	}
}
