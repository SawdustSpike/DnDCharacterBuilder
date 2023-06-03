using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDApp.ExternalService.DnDApi.Interfaces
{
    internal interface IDnDApiService<TRequest, TResponse> where TRequest : DnDApiRequest<TResponse>
    {
        public Task<TResponse> GetResponseAsync(TRequest request);
    }
}
