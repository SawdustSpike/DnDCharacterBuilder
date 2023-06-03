using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDApp.Domain.Models
{
    public class Skill
    {
        public Skill(string name, string uRL, AbilityScore ability, string[] desc, int modifier)
        {
            Name = name;
            URL = uRL;
            Ability = ability;
            Desc = desc;
            Modifier = modifier;
        }
        public string Name { get; set; }
        public string URL { get; set; }
        public AbilityScore Ability { get; set; }
        public string[] Desc { get; set; }
        public int Modifier { get; set; }

    }
}
