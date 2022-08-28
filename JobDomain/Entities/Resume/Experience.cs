using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobDomain.Entities.Resume
{
    public class Experience : Base
    {
        [Required]
        public string CompanyNane { get; set; }
        [Required]
        public int StartMonth { get; set; }
        [Required]
        public int StartYear { get; set; }
        public int? EndMonth { get; set; }
        public int? EndYear { get; set; }
    }
}
