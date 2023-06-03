using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DnDApp.Domain.Models
{
    public class Player
    {
        public Player()
        {
            
        }
        public AbilityScore[] AbilityScores { get; set; }
        public string Name { get; set; }
        public Skill[] Skills { get; set; }
        public Alignment Alignment { get; set; }

    }
}
