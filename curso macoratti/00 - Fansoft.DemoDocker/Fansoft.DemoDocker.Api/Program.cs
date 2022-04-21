using Fansoft.DemoDocker.Api.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddTransient<IProdutoRepository, ProdutoRepository>();

var app = builder.Build();
app.MapControllers();
app.Run();