using Microsoft.Extensions.DependencyInjection;
using Reboot.DDD.Demo.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reboot.DDD.Demo.Domain;
public static class DomainModule
{
    public static IServiceCollection Register(this IServiceCollection services)
    {
        services.AddScoped<IOrderService, OrderService>();
        return services;
    }
}
