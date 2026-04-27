using Scalar.AspNetCore;
using DbMigration;
using Microsoft.EntityFrameworkCore;
using FollowingServerDAL.Context;
using FollowingServerBL.Services;
using FollowingServerDAL.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<FollowingDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<CountryRepository>();
builder.Services.AddScoped<CountryService>();


// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

builder.Services.AddEndpointsApiExplorer(); // חובה
builder.Services.AddOpenApi();


DbMigrationTool.Migrate(builder.Configuration);

var app = builder.Build();
//app.MapControllers();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference(); // יצירת הממשק הגרפי לבדיקה
    //https://localhost:44316/scalar/ 
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();