using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Reboot.DDD.Demo.Infrastructure.EFCore;
public static class InfrastructureEFCoreModule
{
    public static IServiceCollection Register(this IServiceCollection services)
    {
        services.AddDbContext<DemoDbContext>(options =>
            options.UseSqlite("Data Source=demo.db")
        );
        return services;
    }
}
