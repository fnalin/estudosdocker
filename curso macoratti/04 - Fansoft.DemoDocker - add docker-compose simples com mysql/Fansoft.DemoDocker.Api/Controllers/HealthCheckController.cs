using Microsoft.AspNetCore.Mvc;

namespace Fansoft.DemoDocker.Api.Controllers;

public class HealthCheckController : ControllerBase
{
    private readonly IConfiguration _config;

    public HealthCheckController(IConfiguration config)
    {
        _config = config;
        
    }
    [Route("api/v1/ping")]
    public string Ping() => $"Pong no {_config["HOSTNAME"]}";
}