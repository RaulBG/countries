using Countries.Domain.Models;
using Countries.Infraestructure.Repositories;
using MediatR;

namespace Countries.Application.Queries
{


    public class GetCountries : IRequest<IEnumerable<Country>>
    {
       // private readonly ICountryRepo _countryRepo;

        public GetCountries()
        {
            
        }        
    }

    public class GetCountriesHandler : IRequestHandler<GetCountries, IEnumerable<Country>>
    {
        private readonly ICountryRepo _countryRepo;
        public GetCountriesHandler (ICountryRepo countryRepo)
        {
            _countryRepo = countryRepo;
        }

        public async Task<IEnumerable<Country>> Handle(GetCountries request, CancellationToken cancellationToken)
            => await _countryRepo.GetAll();
        
    }

}
