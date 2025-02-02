using Microsoft.AspNetCore.Mvc;
using Reboot.DDD.Demo.Api.Dto;
using Reboot.DDD.Demo.Application;
using Reboot.DDD.Demo.Domain.Services;

namespace Reboot.DDD.Demo.Api.Endpoints;

public static class OrderEndpoints
{
    public static RouteGroupBuilder RegisterOrderEndpoints(this RouteGroupBuilder app)
    {
        app.MapPost("/order", async (
            [FromBody] PayOrderRequest request,
            [FromServices] IOrderAppService OrderService
        ) =>
        {
            var order = await OrderService.ProcessOrderPayment(request);
            return order;
        });

        return app;
    }
}
