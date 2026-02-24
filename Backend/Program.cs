using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;
using Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(options =>
options.AddPolicy( "AllowAll", policy =>{
    policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
})
);

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var connectionString = "Host=localhost;Port=5432;Database=shinroll;Username=postgres;Password=*Ker8Z4ILM";
builder.Services.AddDbContext<AppDbContextPOSTGRES>(options =>
    options.UseNpgsql(connectionString));

var connectionString = Environment.GetEnvironmentVariable("DATABASE_URL");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseCors("AllowAll");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
