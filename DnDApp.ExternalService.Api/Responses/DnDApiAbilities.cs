using DnDApp.ExternalService.DnDApi.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDApp.ExternalService.DnDApi.Responses
{
    public class DnDApiAbility
    {
        public string Name { get; set; }
        public string Abbr { get; set; }
        public string Url { get; set; }
        public string[] Desc { get; set; }
        public string[] Skills { get; set; }



    }
}
