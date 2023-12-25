using Microsoft.AspNetCore.Mvc;

namespace Account.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing_Acount", "Bracing_Acount", "Chilly_Acount", "Cool_Acount", "Mild_Acount", "Warm_Acount", "Balmy_Acount", "Hot_Acount", "Sweltering_Acount", "Scorching"
    };

        private readonly ILogger<AccountForecastController> _logger;

        public AccountForecastController(ILogger<AccountForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "AccountGet")]
        public IEnumerable<WeatherForecast> AccountGet()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}