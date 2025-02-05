
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ResumeAPI.Data.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.ConfigureSwaggerGen(setup =>
{
    setup.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "Resume Endpoints",
        Version = "v1"
    });
});

string? defaultConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");
if (defaultConnectionString == null)
{
    throw new Exception($"Connectionstring: DefaultConnection");
}

builder.Services.AddDbContext<ResumeAPIContext>(options =>
{
    options.UseSqlServer(defaultConnectionString);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();

if (app.Environment.IsDevelopment())
{
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
