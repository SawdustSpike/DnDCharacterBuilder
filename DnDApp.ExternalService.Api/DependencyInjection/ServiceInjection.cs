using DnDApp.ExternalService.DnDApi.Interfaces;
using DnDApp.ExternalService.DnDApi.ServiceRouter;
using Microsoft.Extensions.DependencyInjection;
namespace DnDApp.ExternalService.DnDApi.DependencyInjection
{
    public static class ServiceInjection
    {
        public static IServiceCollection InjectDnDApiService(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }
            services.AddSingleton<IDnDApiServiceRouter, DnDApiServiceRouter>();
            return services;
        }
    }
}
