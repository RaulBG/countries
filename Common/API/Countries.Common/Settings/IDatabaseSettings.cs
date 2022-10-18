using Microsoft.Extensions.Configuration;

namespace Common.Settings
{
    public interface IDatabaseSettings
    {
         string BuildConnectionString(IConfiguration config);
    }
}
