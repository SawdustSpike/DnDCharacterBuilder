using DnDApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDApp.ExternalService.DnDApi.Interfaces
{
    public interface IDnDApiServiceRouter
    {
       

        public Task<IEnumerable<AlignmentScore>> GetAllAlignmentsAsync();
        public Task<IEnumerable<Skill>> GetAllSkillsAsync();
        public Task<IEnumerable<Alignment>> GetAllAlignmentsAsync();
        public Task<Alignment> GetAlignmentAsync();
      



    }
}
