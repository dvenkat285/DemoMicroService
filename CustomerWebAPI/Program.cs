using CustomerWebAPI;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//Database Context Dependency Injection
var dbHost = "172.16.15.26";
var dbName = "dms_customer";
var dbPassword = "Joshjess_285";
var connectionString = $"Data Source={dbHost};Initial Catalog={dbName};User id =Venkatesh.K; Password={dbPassword}";
builder.Services.AddDbContext<CustomerDbContext>(opt => opt.UseSqlServer(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
