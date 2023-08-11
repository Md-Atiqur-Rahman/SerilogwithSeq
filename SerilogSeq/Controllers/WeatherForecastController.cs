using Microsoft.AspNetCore.Mvc;

namespace SerilogSeq.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetLog")]
        public IActionResult GetLog()
        {
            _logger.LogInformation("Log message form information method");
            _logger.LogWarning("Log message form Warning method");
            _logger.LogError("Log message form Error method");
            _logger.LogTrace("Log message form Trace method");
            _logger.LogDebug("Log message form Debug method");
            _logger.LogCritical("Log message form Critical method");
            return Ok();
        }
    }
}