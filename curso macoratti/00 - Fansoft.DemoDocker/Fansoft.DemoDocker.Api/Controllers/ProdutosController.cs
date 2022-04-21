using Fansoft.DemoDocker.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fansoft.DemoDocker.Api.Controllers;

[Route("api/v1/[controller]")]
public class ProdutosController : Controller
{
    private readonly IProdutoRepository _produtoRepository;

    public ProdutosController(IProdutoRepository produtoRepository)
    {
        _produtoRepository = produtoRepository;
    }

    public IActionResult Get() => Ok(_produtoRepository.Produtos);
}