namespace Fansoft.DemoDocker.Api.Models;

public class ProdutoRepository : IProdutoRepository
{

    public ProdutoRepository(AppDbContext ctx)
    {
        _ctx = ctx;
    }
    public IEnumerable<Produto> Produtos
    {
        get => _ctx.Produtos.ToList();
    }

    private readonly AppDbContext _ctx;
}