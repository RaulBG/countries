using Microsoft.AspNetCore.Mvc;
using Countries.Domain.Models;

namespace Countries.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContryController : ControllerBase
    {       
        private readonly ILogger<ContryController> _logger;

        public ContryController(ILogger<ContryController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("GetCountry")]
        public Country Get()
        {
            Country contry = new Country();
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = Random.Shared.Next(-20, 55),
            //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            //})
            //.ToArray();
            return contry;
        }

        [HttpGet]
        [Route("GetCountries")]
        public IEnumerable<Country> GetAll()
        {
            IEnumerable<Country>contries = new List<Country>();
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = Random.Shared.Next(-20, 55),
            //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            //})
            //.ToArray();
            return contries;

        }
    }
}