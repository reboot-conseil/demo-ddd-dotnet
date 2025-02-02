using Microsoft.Extensions.DependencyInjection;
using Reboot.DDD.Demo.Domain.Services;

namespace Reboot.DDD.Demo.Infrastructure.Paypal;

public static class InfrastructurePaypalModule
{
    public static IServiceCollection Register(this IServiceCollection services)
    {
        services.AddScoped<IPaymentService, PaypalPaymentService>();
        return services;
    }
}
