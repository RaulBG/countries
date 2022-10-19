using Common.Infraestructure.EF.Common;
using Common.Settings;
using Microsoft.EntityFrameworkCore;

namespace Common.Infraestructure.EF.Base
{
    public abstract class BaseContext : DbContext, ICommonDbContext
    {

        /// <summary>
        /// Cadena de conexión
        /// </summary>
        protected string ConnectionString { get; set; }
        protected string DataProvider { get; set; } = "SQLServer"; // "MySQL"



        protected BaseContext() : base()
        {
            //// Get the current configuration file.
            //Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //var customSection = config.GetSection("CustomSection") ;
            //string logDbConnectionString = _configuration.GetValue<string>("Modules:Logging:logDb"); // read logDb connection 
            //string application = _configuration.GetSection(AppSettings.Tenants)[host];

            //ConfigurationSection Tenant = _configuration.GetSection(AppSettings.ApplicationSettings).GetSection(application);


            //CustomSection customSection;

            //// Get the current configuration file.
            //Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            //Configuration configuration = new ModelConfigurationBuilder()
            //                .AddJsonFile("appsettings.json")
            //                .Build();



            ConnectionString = $"Server=DESKTOP-LMIQ792\\SQLEXPRESS;User Id=contries;Password=contriesPW;MultipleActiveResultSets=True";
        }

        /// <summary>
        /// Contructor que recibe opciones de conexión
        /// </summary>
        /// <param name="options">Opciones de conexión</param>
        public BaseContext(DbContextOptions options)
            : base(options)
        {
            //Database.ExecuteSqlCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;");
        }

        /// <summary>
        /// Constructor que recibe una cadena de conexión
        /// </summary>
        /// <param name="connectionString">Cadena de Conexión</param>
        public BaseContext(string connectionString)
            : base()
        {
            ConnectionString = connectionString;
            //Database.ExecuteSqlCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;");
        }

        public BaseContext(string connectionString, string dataProvider = "SQLServer")
           : base()
        {
            DataProvider = dataProvider;
            ConnectionString = connectionString;
            //Database.ExecuteSqlCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;");
        }
        
        public BaseContext(IDatabaseSettings settings, IConfiguration configuration, string dataProvider = "SQLServer")
           : base()
        {
            DataProvider = dataProvider;
            ConnectionString = settings.BuildConnectionString(configuration);

        }

        /// <summary>
        /// Sobreescribe la configuracion pasando la cadena de conexion y el provider. 
        /// Es necesario tener esta funcion
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.
        //}

    }
}
