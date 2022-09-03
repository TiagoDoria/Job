using System.ComponentModel.DataAnnotations;

namespace JobDomain.Dtos.Resume
{
    public class FormationDto
    {
        public int Id { get; set; }
        [Required]
        public string Institution { get; set; }
        [Required]
        public int Start { get; set; }
        public int? End { get; set; }
    }
}
