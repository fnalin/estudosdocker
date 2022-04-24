namespace Fansoft.DemoDocker.Api.Models;

public interface IProdutoRepository
{
    IEnumerable<Produto> Produtos { get; }
}