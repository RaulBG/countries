using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Settings
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public DatabaseSettings()
        {
        }

        public  string BuildConnectionString(IConfiguration config)
        {
            DatabaseConfiguration dbConfiguration = new DatabaseConfiguration();
            config.Bind(key: "ApplicationsSettings:Contries:ConnectionStrings:DefaultConnection", dbConfiguration);

            // IConfigurationSection section = config.GetSection(key: "ApplicationsSettings:Contries:ConnectionStrings:DefaultConnection");
            string connectionString = @$"Server={dbConfiguration.Server}
                                            User={dbConfiguration.User}
                                            Password={dbConfiguration.Password}
                                            {(dbConfiguration.MultipleActiveResultSets ? "MultipleActiveResultSets=true" : string.Empty)}";
            return connectionString;
           }                   
    }
}
