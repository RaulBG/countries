using Microsoft.EntityFrameworkCore;
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

        public async Task<List<Country>> GetAll()
        {
            var result = _table.AsNoTracking()               
                .Include(c => c.Idd)
                .Include(c => c.Currencies)
                .Include(c => c.Maps)
                .Include(c => c.CapitalInfo)
                .Include(c => c.Car)
                .Include(c => c.CoatOfArms)               
                .Include(c => c.PostalCode)
                .Include(c => c.Demonyms)
                .Include(c => c.Flags)
                .Include(c => c.Translations)
                .Include(c=>c.Name).ThenInclude(n=>n.NativeNameTranslations);

            return await result.ToListAsync();
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

