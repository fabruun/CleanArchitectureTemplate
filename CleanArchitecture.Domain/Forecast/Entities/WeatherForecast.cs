using CleanArchitecture.Domain.Common.Models;

namespace CleanArchitecture.Domain.Forecast.Entities;

public class WeatherForecast : ValueObject
{
    public DateOnly Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Date;
        yield return TemperatureC;
        yield return TemperatureF;
        yield return Summary ?? string.Empty;
    }
}