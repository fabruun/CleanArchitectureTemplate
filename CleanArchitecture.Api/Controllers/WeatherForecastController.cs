using CleanArchitecture.Contracts.Forecast;

namespace CleanArchitecture.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    
    
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IWeatherForecastService _weatherForecastService;

    public WeatherForecastController(
        ILogger<WeatherForecastController> logger,
        IWeatherForecastService weatherForecastService)
    {
        _logger = logger;
        _weatherForecastService = weatherForecastService;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecastResponse> Get()
    {
        var result = _weatherForecastService.Get();
        var response = result.Select(x => new WeatherForecastResponse(
                Date: x.Date,
                Celcius: x.TemperatureC,
                Fahrenheit: x.TemperatureF,
                Summary: x.Summary
        )); 
        return response;
    }
}