using Microsoft.EntityFrameworkCore;
using SensoresIoT.Repositories;

namespace SensoresIoT.SensoresIoTAPI.Configuration
{
    public static class ConfigurationDb
    {
        public static IServiceCollection AddConfigurationDba(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<DispositivosIoTContext>(c => c.UseSqlServer(configuration.GetConnectionString("DispositivosIoTDb")));
            return service;
        }
    }
}
