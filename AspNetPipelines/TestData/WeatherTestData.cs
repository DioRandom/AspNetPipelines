using AspNetPipelines.Core.Enums;
using AspNetPipelines.Core.Types;

namespace AspNetPipelines.Api.TestData
{
    public static class WeatherTestData
    {
        public static List<WeatherForecast> WeatherForecasts => new List<WeatherForecast>()
        {
            new WeatherForecast
            {
                City = "Lviv",
                Date = new DateOnly(2023, 5, 6),
                Summary = "Cold",
                UnitValue = new Dictionary<TemperatureUnits, int>
                {
                    { TemperatureUnits.Celsius, 35 }
                }
            },
             new WeatherForecast
            {
                 City = "Kiev",
                Date = new DateOnly(2023, 5, 6),
                Summary = "Cold",
                UnitValue = new Dictionary<TemperatureUnits, int>
                {
                    { TemperatureUnits.Celsius, 15 }
                }
            },
              new WeatherForecast
            {
                  City = "Chernivtsi",
                Date = new DateOnly(2023, 5, 4),
                Summary = "Cold",
                UnitValue = new Dictionary<TemperatureUnits, int>
                {
                    { TemperatureUnits.Celsius, 5 }
                }
            },
               new WeatherForecast
            {
                   City = "Odesa",
                Date = new DateOnly(2023, 5, 6),
                Summary = "Cold",
                UnitValue = new Dictionary<TemperatureUnits, int>
                {
                    { TemperatureUnits.Celsius, 55 }
                }
            }
        };
    }
}
