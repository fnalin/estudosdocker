using Fansoft.DemoDocker.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fansoft.DemoDocker.Api.Controllers;

[Route("api/v1/[controller]")]
public class ProdutosController : Controller
{
    private readonly IProdutoRepository _produtoRepository;
    private readonly IConfiguration _config;

    public ProdutosController(
        IProdutoRepository produtoRepository,
        IConfiguration config)
    {
        _produtoRepository = produtoRepository;
        _config = config;
    }

    public IActionResult Get() => 
        Ok(new {host = _config["HOSTNAME"], _produtoRepository.Produtos});
}