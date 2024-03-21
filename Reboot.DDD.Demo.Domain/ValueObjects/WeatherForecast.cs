namespace Reboot.DDD.Demo.Domain.ValueObjects;

public class WeatherForecast(DateTime date, int temperatureC, string? summary)
{
    public DateTime Date { get; init; } = date;

    public int TemperatureC { get; init; } = temperatureC;

    public string? Summary { get; init; } = summary;

    public int TemperatureF => 32 + (int)(TemperatureC * 1.8);
}
