namespace CleanArchitecture.Contracts.Forecast;

public record WeatherForecastResponse(
    DateOnly Date,
    int Celcius,
    int Fahrenheit,
    string? Summary);