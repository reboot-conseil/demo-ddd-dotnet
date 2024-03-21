using Reboot.DDD.Demo.Domain.Services;
using Reboot.DDD.Demo.Domain.ValueObjects;

namespace Reboot.DDD.Demo.Infrastructure.Weather;
internal class WeatherService : IWeatherService
{
    private static readonly string[] summaries = [
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    ];

    public WeatherForecast GetWeatherForecast(int day)
    {
        return new WeatherForecast
        (
            DateTime.Now.AddDays(day),
            Random.Shared.Next(-20, 50),
            summaries[Random.Shared.Next(summaries.Length)]
        );
    }
}
