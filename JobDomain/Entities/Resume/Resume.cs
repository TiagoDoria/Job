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
        public Formation Formation { get; set; }
        public Experience Experience { get; set; }
        public Certificate Certificate { get; set; }
        public Language Language { get; set; }
        public int CandidateId { get; set; }

    }
}
