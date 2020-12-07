using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApp.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class WeatherForecastController : ControllerBase
	{
		private static readonly string[] Summaries = new[]
		{
			"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
		};

		private readonly ILogger<WeatherForecastController> _logger;

		public WeatherForecastController(ILogger<WeatherForecastController> logger)
		{
			_logger = logger;
		}

		[HttpGet]
		public IEnumerable<WeatherForecast> Get()
		{
			var rng = new Random();
			return Enumerable.Range(1, 5).Select(index => new WeatherForecast
			{
				Date = DateTime.Now.AddDays(index),
				TemperatureC = rng.Next(-20, 55),
				Summary = Summaries[rng.Next(Summaries.Length)]
			})
			.ToArray();
		}
		
		[HttpGet]
		public ActionResult GetData()
		{
			return Ok("123456");
		}
		
		[HttpGet]
		public ActionResult GetData2()
		{
			return Ok("123456");
		}
		
		[HttpGet]
		public ActionResult GetData3()
		{
			return Ok("123456");
		}

		[HttpGet]
		public ActionResult GetData5()
		{
			return Ok("123456");
		}

		[HttpGet]
		public ActionResult GetData6()
		{
			return Ok("123456");
		}
		
		[HttpGet]
		public ActionResult GetData9()
		{
			return Ok("123456");
		}

		[HttpGet]
		public ActionResult GetData10()
		{
			return Ok("123456");
		}
		
		[HttpGet]
		public ActionResult GetData12()
		{
			return Ok("123456");
		}

		[HttpGet]
		public ActionResult GetData11()
		{
			return Ok("123456");
		}
		
		[HttpGet]
		public ActionResult GetData13()
		{
			return Ok("123456");
		}
	}
}
