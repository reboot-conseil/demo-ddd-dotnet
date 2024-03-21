using Reboot.DDD.Demo.Api.Endpoints;
using Reboot.DDD.Demo.Infrastructure.EFCore;
using Reboot.DDD.Demo.Infrastructure.Weather;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

InfrastructureWeatherModule.Register(builder.Services);
InfrastructureEFCoreModule.Register(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapEndpoints();

app.Run();
