using System;
//pull Request Artifact 2
namespace ArquitecturaBase
{
    public class WeatherForecast
    {
        // Nuevo comentario
        public DateTime Date { get; set; }
        
        // Nuevo comentario GitHub PullRequest
        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
