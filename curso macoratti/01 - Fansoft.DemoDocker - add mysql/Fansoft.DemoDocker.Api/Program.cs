using Fansoft.DemoDocker.Api.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

var host = builder.Configuration["DBHOST"] ?? "localhost";
var port = builder.Configuration["DBPORT"] ?? "3306";
var password = builder.Configuration["DBPASSWORD"] ?? "123456@qwerty";
var connString = $"server={host};userid=root;pwd={password};port={port};database=produtosdb";
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(
        connString,
        ServerVersion.AutoDetect(connString)
    ));

builder.Services.AddTransient<IProdutoRepository, ProdutoRepository>();

var app = builder.Build();
app.MapControllers();
app.Run();