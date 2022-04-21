namespace Fansoft.DemoDocker.Api.Models;

public class ProdutoRepository : IProdutoRepository
{
    public IEnumerable<Produto> Produtos
    {
        get => dados;
    }

    private static Produto[] dados = new Produto[]
    {
        new Produto() {ProdutoId = 10, Nome = "Caneta", Categoria = "Material", Preco = 2 },
        new Produto() {ProdutoId = 20, Nome = "Borracha", Categoria = "Material", Preco = 5 },
        new Produto() {ProdutoId = 30, Nome = "Estojo", Categoria = "Material", Preco = 10.5M },
    };
}