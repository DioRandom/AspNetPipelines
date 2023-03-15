using AspNetPipelines.Api.DataAccess;
using AspNetPipelines.Api.Extegions;
using AspNetPipelines.Api.TestData;
using AspNetPipelines.Core.Enums;
using AspNetPipelines.Core.Extensions;
using AspNetPipelines.Core.Types;
using Microsoft.AspNetCore.Mvc;

namespace AspNetPipelines.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IRepository<WeatherForecast> _repository;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,
            IRepository<WeatherForecast> repository)
        {
            _logger = logger;
            _repository = repository;
        }
        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> GetWeatherForecast(string city, int days = 3, TemperatureUnits unit = TemperatureUnits.Celsius)
        {
            var weatherEntries = _repository.GetAll<WeatherForecast>()
                .Where(x => x.City == city)
                .Take(days)
                .Select(entry => 
                {
                    entry.UnitValue[TemperatureUnits.Fahrenheit] = entry.UnitValue[TemperatureUnits.Celsius].ToFahrenheit();

                    return entry;
                });

            return weatherEntries;
        }
    }
}