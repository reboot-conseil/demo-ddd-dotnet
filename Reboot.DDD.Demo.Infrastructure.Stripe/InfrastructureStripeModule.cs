using Reboot.DDD.Demo.Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Reboot.DDD.Demo.Infrastructure.Stripe;

public static class InfrastructureStripeModule
{
    public static IServiceCollection Register(this IServiceCollection services)
    {
        services.AddScoped<IPaymentService, StripePaymentService>();
        return services;
    }
}
