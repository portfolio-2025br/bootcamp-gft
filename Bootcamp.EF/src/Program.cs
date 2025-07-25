using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using TrilhaApiDesafio.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<OrganizadorContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao")));

builder.Services.AddControllers().AddJsonOptions(options =>
    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Obtém informações sobre a sessão
app.MapGet("/info", (HttpContext context) =>
{
    var usuario = context.User.Identity?.Name;
    var ip = context.Connection.RemoteIpAddress?.ToString();
    var descricao = "Desafio Entity Framework";

    return Results.Ok(new { usuario, ip, descricao });
});

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
