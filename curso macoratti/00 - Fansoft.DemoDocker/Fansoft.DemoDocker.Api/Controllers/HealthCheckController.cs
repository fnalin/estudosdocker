using Microsoft.AspNetCore.Mvc;

namespace Fansoft.DemoDocker.Api.Controllers;

public class HealthCheckController : ControllerBase
{
    [Route("api/v1/ping")]
    public string Ping() => "Pong";
}