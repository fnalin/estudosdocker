using Microsoft.EntityFrameworkCore;

namespace Fansoft.DemoDocker.Api.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }

    public DbSet<Produto> Produtos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Produto>().HasData(
            new Produto {ProdutoId = 1, Nome = "Picanha",Categoria = "Alimento", Preco = 100.99M},
            new Produto {ProdutoId = 2, Nome = "Danone",Categoria = "Alimento", Preco = 9.99M},
            new Produto {ProdutoId = 3, Nome = "Tenis",Categoria = "Vestimento", Preco = 245.9M},
            new Produto {ProdutoId = 4, Nome = "Sulfite",Categoria = "Papelaria", Preco = 5.99M}
        );
    }
}