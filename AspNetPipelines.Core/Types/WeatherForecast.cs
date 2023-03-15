using AspNetPipelines.Core.Enums;

namespace AspNetPipelines.Core.Types
{
    public class WeatherForecast
    {
        public string? City { get; set; }

        public DateOnly Date { get; set; }

        public Dictionary<TemperatureUnits, int>? UnitValue { get; set; } = new Dictionary<TemperatureUnits, int>();

        // real feel

        // infra-red index

        // wind

        public string? Summary { get; set; }
    }
}