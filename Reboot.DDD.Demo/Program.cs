using Reboot.DDD.Demo.Api.Endpoints;
using Reboot.DDD.Demo.Application;
using Reboot.DDD.Demo.Domain;
using Reboot.DDD.Demo.Infrastructure.EFCore;
using Reboot.DDD.Demo.Infrastructure.Paypal;
using Reboot.DDD.Demo.Infrastructure.Repositories;
using Reboot.DDD.Demo.Infrastructure.Stripe;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//InfrastructureStripeModule.Register(builder.Services);
InfrastructurePaypalModule.Register(builder.Services);
InfrastructureEFCoreModule.Register(builder.Services);
ApplicationModule.Register(builder.Services);
DomainModule.Register(builder.Services);
InfrastructureRepositoriesModule.Register(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapEndpoints();

await app.RunAsync();
