using System;

namespace ArquitecturaBase
{
    public class WeatherForecast
    {
        // Nuevo comentario
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
