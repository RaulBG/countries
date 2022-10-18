using Common.Infraestructure.EF.Base;
using Common.Infraestructure.EF.Common;
using Common.Settings;
using Countries.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Countries.Infraestructure.EF
{
    public class CountriesDbContext : BaseContext, ICommonDbContext
    {

        private readonly IDatabaseSettings _databaseSettings;
        private readonly IConfiguration _configuration;
        /// <summary>
        /// Constructor por connectionstring y context (para los test)
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="dataProvider"></param>
        public CountriesDbContext(string connectionString, string dataProvider = "SQLServer")
            : base(connectionString, dataProvider)
        { }

        public CountriesDbContext(string connectionString)
            : base(connectionString)
        {
           
        }
        public CountriesDbContext(IDatabaseSettings settings, IConfiguration configuration) : base(settings, configuration)
        { 
            _databaseSettings = settings;
            _configuration = configuration;
        }

        public DbSet<Country> contries { get; set; }
        public DbSet<Name> names { get;set; }
    }
}
