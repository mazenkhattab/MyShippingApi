using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using MyShippingApi.Factories;
using MyShippingApi.Strategies;

var builder = WebApplication.CreateBuilder(args);

// Register services
builder.Services.AddControllers();
builder.Services.AddAuthorization(); // Add authorization services

// Register the factory provider
builder.Services.AddTransient<ShippingFactoryProvider>();

// Register strategy factories
builder.Services.AddTransient<AirShippingFactory>();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization(); // Use authorization middleware

app.MapControllers();

app.Run();
