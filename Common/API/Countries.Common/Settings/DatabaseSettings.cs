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
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Server={0};", dbConfiguration.Server);
            sb.AppendFormat("User Id={0};", dbConfiguration.User);
            sb.AppendFormat("Password={0};", dbConfiguration.Password);
            sb.AppendFormat("Database={0};", dbConfiguration.Database);

            if(dbConfiguration.MultipleActiveResultSets)
                sb.Append("MultipleActiveResultSets=true;");
            
            return sb.ToString();
           }                   
    }
}
