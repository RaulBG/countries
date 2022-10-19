using Microsoft.Data.SqlClient.Server;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Countries.Domain.Models;
using Countries.Infraestructure.EF;

namespace Countries.Infraestructure.Repositories
{
    public class CountryRepo : ICountryRepo
    {
        private DbSet<Country> _table;
        private DbContext _context;

        public CountryRepo(CountriesDbContext context)
        {
            InitializeRepoDbSets(context);
        }

        private void InitializeRepoDbSets(CountriesDbContext context)
        {
            _table = context.Set<Country>();
            _context = context;
        }

        public int Add(Country country, bool persist = true)
        {
            _table.Add(country);
            return persist ? SaveChanges() : 0;
        }

        public Task<Country> GetByIdAsync(int id, bool noTracking = true)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            int result = _context.SaveChangesAsync().GetAwaiter().GetResult();
            return result;
        }

        public int Update(Country country, bool persist = true)
        {
            throw new NotImplementedException();
        }
        public int Delete(Country country, bool persist = true)
        {
            _table.Remove(country);
            return persist ? SaveChanges() : 0;
        }


    }
}

