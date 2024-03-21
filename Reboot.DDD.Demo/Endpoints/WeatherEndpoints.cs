using Microsoft.AspNetCore.Mvc;
using Reboot.DDD.Demo.Api.Dto;
using Reboot.DDD.Demo.Domain.Services;

namespace Reboot.DDD.Demo.Api.Endpoints;

public static class WeatherEndpoints
{
    public static RouteGroupBuilder RegisterWeatherEndpoints(this RouteGroupBuilder app)
    {
        app.MapGet("/forecast", ([FromServices] IWeatherService WeatherService) =>
        {
            var forecast = Enumerable.Range(1, 5)
                .Select(index => WeatherService.GetWeatherForecast(index))
                .Select(forecast => new WeatherForecastDto
                {
                    Date = forecast.Date,
                    TemperatureC = forecast.TemperatureC,
                    TemperatureF = forecast.TemperatureF,
                    Summary = forecast.Summary,
                })
                .ToArray();
            return forecast;
        });

        return app;
    }
}
