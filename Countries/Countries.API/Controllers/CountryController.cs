using Microsoft.AspNetCore.Mvc;
using Countries.Domain.Models;
using Countries.Infraestructure.Repositories;
using Countries.Application.Commands;

namespace Countries.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountryController : ControllerBase
    {       
        private readonly ILogger<CountryController> _logger;
        private readonly ICountryRepo _productHomologationsRepo;

        public CountryController(ILogger<CountryController> logger
                                , ICountryRepo productHomologationsRepo)
        {
            _logger = logger;
            _productHomologationsRepo= productHomologationsRepo;    
        }

        [HttpGet]
        [Route("GetCountry")]
        public async Task<ActionResult<Country>> Get()
        {
            Country contry = new Country();
            
            return  Ok(contry);
        }

        [HttpGet]
        [Route("GetCountries")]
        public async Task<ActionResult<IEnumerable<Country>>> GetAll()
        {
            IEnumerable<Country>contries = new List<Country>();
           
            return Ok(contries);
        }

        [HttpPost]
        public async Task<bool> Add([FromBody]Country country)
        {
            _logger.LogInformation("Add Country");
            var handlerAdd = new AddContryHandler(_productHomologationsRepo);
            
            return await handlerAdd.Add(country)>0;
        }
    }
}