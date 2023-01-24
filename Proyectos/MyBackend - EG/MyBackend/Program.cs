using ApiBackend.DataAccess;
using ApiBackend.Services;
using Microsoft.EntityFrameworkCore;


    var builder = WebApplication.CreateBuilder(args);

//2.conexion with SQL server express
const string ConnectionName = "UniversityDB";
var connectionString = builder.Configuration.GetConnectionString(ConnectionName);

//3.Add context
builder.Services.AddDbContext<UniversityDBContext>(options => options.UseSqlServer(connectionString));  

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<Service>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
