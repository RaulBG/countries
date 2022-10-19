using Countries.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countries.Infraestructure.Repositories
{
    public interface ICountryRepo
    {
        int Update(Country country, bool persist = true);
        int Add(Country country, bool persist = true);
        int Delete(Country country, bool persist = true);
        int SaveChanges();
        Task<Country> GetByIdAsync(int id, bool noTracking = true);
    }
}
