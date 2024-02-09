using Microsoft.AspNetCore.Mvc;

namespace ansible.Controllers;

[ApiController]
[Route("/test")]
public class WeatherForecastController : ControllerBase
{

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public string Get()
    {
        return "gokselaktas"
    }
}
