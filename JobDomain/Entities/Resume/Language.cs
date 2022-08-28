using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobDomain.Entities.Resume
{
    public class Language : Base
    {
        [Required]
        public string Description { get; set; }
        [Required]
        public string Level { get; set; }
    }
}
