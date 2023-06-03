using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDApp.ExternalService.DnDApi.Responses
{
    public class DnDApiSkill
    {
        public string  Name { get; set; }
        public string[] Desc { get; set; }
        public string Url { get; set; }
        public string Ability { get; set; }

    }
}
