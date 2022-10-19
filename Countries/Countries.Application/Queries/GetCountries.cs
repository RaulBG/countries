using Countries.Domain.Models;
using Countries.Infraestructure.Repositories;


namespace Countries.Application.Queries
{
    public class GetCountries
    {
        private readonly ICountryRepo _countryRepo;

        public GetCountries(ICountryRepo productHomologationsRepo)
        {
            _countryRepo = productHomologationsRepo;
        }

        public async Task<List<Country>> GetAll()
        {
            return await _countryRepo.GetAll();
        }
    }
}
