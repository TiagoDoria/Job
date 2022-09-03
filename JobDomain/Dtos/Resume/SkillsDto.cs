using System.ComponentModel.DataAnnotations;


namespace JobDomain.Dtos.Resume
{
    public class SkillsDto
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Level { get; set; }
    }
}
