using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PT_Hiberus_API.Domain.IRepositories;
using PT_Hiberus_API.Domain.IServices;
using PT_Hiberus_API.Persistence.Context;
using PT_Hiberus_API.Persistence.Repositories;
using PT_Hiberus_API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string? mySqlConnection = builder.Configuration.GetConnectionString("BaseConnection");
builder.Services.AddDbContext<AplicationDbContext>(options =>
options.UseMySql(mySqlConnection, ServerVersion.AutoDetect(mySqlConnection)));

// Repositories
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ILoginRepository, LoginRepository>();

// Services
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ILoginService, LoginService>();

//Cors
builder.Services.AddCors(options => options.AddPolicy("AllowWebApp",
    builder => builder.AllowAnyOrigin()
    .AllowAnyHeader()
    .AllowAnyMethod()
    ));

builder.Services.AddControllers();
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

app.UseCors("AllowWebApp");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
