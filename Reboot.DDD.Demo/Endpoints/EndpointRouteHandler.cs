namespace Reboot.DDD.Demo.Api.Endpoints;

public static class EndpointRouteHandler
{
    public static WebApplication MapEndpoints(this WebApplication app)
    {
        app.MapGroup("/order").RegisterOrderEndpoints().WithTags("Order");
        return app;
    }
}
