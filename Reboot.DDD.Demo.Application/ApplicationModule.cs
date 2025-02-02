using Microsoft.Extensions.DependencyInjection;
using Reboot.DDD.Demo.Domain;

namespace Reboot.DDD.Demo.Application;

public static class ApplicationModule
{
    public static IServiceCollection Register(this IServiceCollection services)
    {
        DomainModule.Register(services);
        services.AddScoped<IOrderAppService, OrderAppService>();
        return services;
    }
}
