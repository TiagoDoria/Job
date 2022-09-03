using System.ComponentModel.DataAnnotations;


namespace JobDomain.Dtos.Resume
{
    public class ResumeDto
    {
        public int Id { get; set; }
        [Required]
        public string Objective { get; set; }
        public List<FormationDto> Formations { get; set; }
        public List<ExperienceDto> Experiences { get; set; }
        public List<SkillsDto> Skills { get; set; }
        public List<CertificateDto> Certificates { get; set; }
        public List<LanguageDto> Languages { get; set; }
        [Required]
        public int CandidateId { get; set; }
    }
}
