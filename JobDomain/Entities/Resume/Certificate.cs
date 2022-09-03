
using System.ComponentModel.DataAnnotations;

namespace JobDomain.Entities.Resume
{
    public class Certificate : Base
    {
        [Required]
        public string Description { get; set; }
        public string Url { get; set; }
    }
}
