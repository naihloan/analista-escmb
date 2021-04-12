using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ManuelBelgrano.WebAppService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Friazo", "Calorón", "Templadito", "Fresco", "Maso", "Cálido", "Muy Cálido", "Infierno", "Mucho Calor", "Santiago del Estero"
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
                Fecha = DateTime.Now.AddDays(index),
                TemperaturaC = rng.Next(-20, 55),
                Descripcion = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
