using DnDApp.ExternalService.DnDApi.Interfaces;
using DnDApp.ExternalService.DnDApi.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DnDApp.ExternalService.DnDApi.ServiceRouter
{
    internal class DnDApiServiceCollection
    {
        private readonly Dictionary<Type, object> _services;

        public DnDApiserviceCollection(params DnDApiServiceRequestContainer[] services)
        {
            _services = new();
            foreach (var service in services)
            {
                AddService(service);
            }
        }
        public DnDApiServiceCollection() : this(DnDApiServiceRequestContainer.ImplementedServices) { }

        private void AddService(DnDApiServiceRequestContainer service)
        {
            if (service == null) throw new ArgumentNullException(nameof(service));

            if (service.Requests.Any())
            {
                foreach (var request in service.Requests)
                {
                    _services.TryAdd(request, service.Implementation);
                }
            }
        }
        public async Task<TResponse> CallService<TRequest, TResponse>(TRequest request) where TRequest : DnDApiRequest<TResponse>
        {
            var service = _services.TryGetValue(request.GetType(), out var serviceInstance)
                ? serviceInstance : throw new ApplicationException($"No service registered of {nameof(request)}");

            if (service is IDnDApiService<TRequest, TResponse> matchedService)
            {
                return await matchedService.GetResponseAsync(request);
            }
            throw new ApplicationException("Service was found but could not match to request.");

        }
    }
}
