using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDApp.Domain.Models
{
    public class AbilityScore
    {
        public AbilityScore(string abbr, string url, string[] desc, string name, Skill[] skills, int score)
        {
            Name = name;
            Skills = skills;
            Abbr = abbr;
            Score = score;
            URL = url;
            Skills = skills;

        }
        public string Abbr { get; set; }
        public string URL { get; set; }
        public string[] Desc { get; set; }
        public string Name { get; set; }

        public Skill[] Skills { get; set; }
        public int Score { get; set; }

    }
}
