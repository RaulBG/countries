using Microsoft.AspNetCore.Mvc;
using Countries.Domain.Models;
using Countries.Infraestructure.Repositories;
using Countries.Application.Commands;
using Countries.Application.Queries;
using MediatR;
using System.Collections.Generic;

namespace Countries.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountryController : ControllerBase
    {       
        private readonly ILogger<CountryController> _logger;
        private readonly ICountryRepo _productHomologationsRepo;
        private readonly IMediator _mediator;
        

        public CountryController(ILogger<CountryController> logger
                                , ICountryRepo productHomologationsRepo
                                , IMediator mediator)
        {
            _logger = logger;
            _productHomologationsRepo= productHomologationsRepo;   
            _mediator= mediator;
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
            //inyection----->
            //_logger.LogInformation("GetCountries");
            //var handlerQuery = new GetCountries(_productHomologationsRepo);           
            //return Ok(await handlerQuery.GetAll());
            
            var countries = await _mediator.Send(new GetCountries());

            return Ok(countries);

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