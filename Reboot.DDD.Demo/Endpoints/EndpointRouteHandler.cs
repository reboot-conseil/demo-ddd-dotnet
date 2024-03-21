namespace Reboot.DDD.Demo.Api.Endpoints;

public static class EndpointRouteHandler
{
    public static WebApplication MapEndpoints(this WebApplication app)
    {
        app.MapGroup("/weather").RegisterWeatherEndpoints().WithTags("Weather");
        app.MapGroup("/users").RegisterUserEndpoints().WithTags("Users");
        return app;
    }
}
