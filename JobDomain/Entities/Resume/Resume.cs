using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobDomain.Entities.Resume
{
    public class Resume : Base
    {
        [Required]
        public string Objective { get; set; }
        public List<Formation> Formations { get; set; }
        public List<Experience> Experiences { get; set; }
        public List<Skills> Skills { get; set; }
        public List<Certificate> Certificates { get; set; }
        public List<Language> Languages { get; set; }
        [Required]
        public int CandidateId { get; set; }

    }
}
