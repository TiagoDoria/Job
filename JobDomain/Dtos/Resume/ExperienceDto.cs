using System.ComponentModel.DataAnnotations;

namespace JobDomain.Dtos.Resume
{
    public class ExperienceDto
    {
        public Guid Id { get; set; }
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
