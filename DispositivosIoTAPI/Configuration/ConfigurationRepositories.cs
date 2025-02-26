using Dipositivos.DispositivosIoT.Application;
using SensoresIoT.DispositivosIot.Domain.IRepositories;
using SensoresIoT.DispositivosIoT.Infrastructure.Repositories;

namespace SensoresIoT.SensoresIoTAPI.Configuration
{
    public static class ConfigurationRepositories
    {
        public static IServiceCollection AddConfigurationRepositories(this IServiceCollection service)
        {
            service.AddScoped<IDispositivosIoTService, DispositivosIoTService>();
            service.AddScoped<IDispositivosIoTRepository, DispositivosIoTRepository>();
            return service;
        }
    }
}
