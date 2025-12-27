using Microsoft.EntityFrameworkCore;
using CentroEstetico.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

// OpenAPI (documentación automática)
builder.Services.AddOpenApi();

builder.Services.AddDbContext<CentroEsteticoDbContext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("DefaultConnection")
    )
);


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/", () => "Centro Estético API funcionando correctamente 🚀");

app.Run();

