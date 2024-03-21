using Reboot.DDD.Demo.Domain.ValueObjects;

namespace Reboot.DDD.Demo.Domain.Services;
public interface IWeatherService
{
    WeatherForecast GetWeatherForecast(int day);
}
