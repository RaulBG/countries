using Countries.Domain.Models;
using Countries.Infraestructure.Repositories;

namespace Countries.Application.Commands
{
    public class AddContryHandler
    {
        private readonly ICountryRepo _productHomologationsRepo;

        public AddContryHandler(ICountryRepo productHomologationsRepo)
        {
            _productHomologationsRepo = productHomologationsRepo;
        }

        public async Task<int> Add(Country country)
        {
            return _productHomologationsRepo.Add(country);
        }
    }
}
