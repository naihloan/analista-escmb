using System;

namespace ManuelBelgrano.WebAppService
{
    public class WeatherForecast
    {
        public DateTime Fecha{get; set; }

        public int TemperaturaC { get; set; }

        public int TemperaturaF => 32 + (int)(TemperaturaC / 0.5556);

        public string Descripcion { get; set; }
    }
}
