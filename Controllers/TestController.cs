using Microsoft.AspNetCore.Mvc;

namespace ansible.Controllers;

[ApiController]
[Route("/test")]
public class TestController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "test ediliyor";
    }
}
