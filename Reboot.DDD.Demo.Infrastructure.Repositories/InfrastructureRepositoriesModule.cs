using Microsoft.Extensions.DependencyInjection;
using Reboot.DDD.Demo.Domain.Repositories;

namespace Reboot.DDD.Demo.Infrastructure.Repositories;

public static class InfrastructureRepositoriesModule
{
    public static IServiceCollection Register(this IServiceCollection services)
    {
        services.AddScoped<IOrderRepository, OrderRepository>();
        return services;
    }
}
