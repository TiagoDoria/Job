using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobDomain.Entities.Resume
{
    public class Formation : Base
    {
        [Required]
        public string Institution { get; set; }

        [Required]
        public int Start { get; set; }
        public int? End { get; set; }
    }
}
