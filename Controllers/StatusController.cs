using Microsoft.AspNetCore.Mvc;

namespace WellMonitoringPractice.Controllers;

[ApiController]
[Route("api/status")]
public class StatusController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "API мониторинга скважин работает";
    }
}