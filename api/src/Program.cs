using Microsoft.EntityFrameworkCore;
using Envy.API.Context;
using Envy.API.Services;
using Envy.API.Interfaces;
using Envy.API.Repositories;

var builder = WebApplication.CreateBuilder(new WebApplicationOptions
{
    EnvironmentName = Environments.Development
});

// Add services to the container.
builder.Services.AddDbContext<EnvyDbContext>(x =>
{
    x.UseNpgsql(builder.Configuration.GetConnectionString("dev"));
});

builder.Services.AddCors(c => {
    c.AddPolicy("dev",
    builder => {
        builder.AllowAnyHeader();
        builder.AllowAnyMethod();
        builder.AllowAnyOrigin();
    });
});

builder.Services.AddScoped<IDeckRepository, DeckRepository>();
builder.Services.AddScoped<ICardRepository, CardRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHealthChecks()
    .AddDbContextCheck<EnvyDbContext>();

var app = builder.Build();

app.MapHealthChecks("health");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("dev");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// Seed data
await SeedService.SeedEntities(app);

app.Run();
