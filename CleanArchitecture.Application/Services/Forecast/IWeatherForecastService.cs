
namespace CleanArchitecture.Application.Services.Forecast;

public interface IWeatherForecastService
{
    IEnumerable<WeatherForecast> Get();
}