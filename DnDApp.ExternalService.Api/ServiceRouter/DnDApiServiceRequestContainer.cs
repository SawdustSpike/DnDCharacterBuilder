using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDApp.ExternalService.DnDApi.ServiceRouter
{
    internal class DnDApiServiceRequestContainer
    {
        public DnDApiServiceRequestContainer(object serviceImplementation, params Type[] requests) 
        {
            Implmentation = serviceImplementation;
            Requests = requests;        
        }

        public object Implmentation { get; set; }

        public IEnumerable<Type> Requests { get; set;} = Enumerable.Empty<Type>();

        public static readonly DnDApiServiceRequestContainer[] ImplementedServices = new DnDApiServiceRequestContainer[]
        {
            new(new DnDApi )
        };
    }
}
