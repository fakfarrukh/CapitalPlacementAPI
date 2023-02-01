using CapitalPlacementAPI.Database;
using CapitalPlacementAPI.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IApplicationFormService,ApplicationFormService>();
builder.Services.AddScoped<IApplicationFormDatabase, ApplicationFormDatabase>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
