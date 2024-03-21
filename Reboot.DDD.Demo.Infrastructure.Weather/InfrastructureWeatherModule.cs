using Reboot.DDD.Demo.Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Reboot.DDD.Demo.Infrastructure.Weather;

public static class InfrastructureWeatherModule
{
    public static IServiceCollection Register(this IServiceCollection services)
    {
        services.AddScoped<IWeatherService, WeatherService>();
        return services;
    }
}
