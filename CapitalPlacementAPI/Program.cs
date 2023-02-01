using CapitalPlacementAPI.Controllers;
using CapitalPlacementAPI.Database;
using CapitalPlacementAPI.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IApplicationFormDatabase, ApplicationFormDatabase>();
builder.Services.AddScoped<IApplicationFormService, ApplicationFormService>();

builder.Services.AddControllers();


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
