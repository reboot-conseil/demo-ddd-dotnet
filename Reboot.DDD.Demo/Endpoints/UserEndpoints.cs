using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Reboot.DDD.Demo.Api.Dto;
using Reboot.DDD.Demo.Domain.Entities;
using Reboot.DDD.Demo.Infrastructure.EFCore;

namespace Reboot.DDD.Demo.Api.Endpoints;

public static class UserEndpoints
{
    public static RouteGroupBuilder RegisterUserEndpoints(this RouteGroupBuilder app)
    {
        app.MapGet("/", ([FromServices] DemoDbContext context) =>
        {
            return context.Users
                .Select(user => new GetUserDto
                {
                    Id = user.Id,
                    Email = user.Email,
                    Name = user.Name,
                })
                .ToListAsync();
        });

        app.MapPost("/", ([FromBody] CreateUserDto dto, [FromServices] DemoDbContext context) =>
        {
            User user = new()
            {
                Email = dto.Email,
                Name = dto.Name,
            };
            context.Users.Add(user);
            context.SaveChangesAsync();
        });

        return app;
    }
}
