using Microsoft.AspNetCore.Mvc;

namespace Product.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing_Product", "Bracing_Product", "Chilly_Product", "Cool_Product", "Mild_Product", "Warm_Product", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<ProductForecastController> _logger;

        public ProductForecastController(ILogger<ProductForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "ProductGet")]
        public IEnumerable<WeatherForecast> ProductGet()
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