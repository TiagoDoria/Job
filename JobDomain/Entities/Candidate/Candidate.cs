using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JobDomain.Entities.Candidate
{
    public class Candidate : Base
    {
        [Required(ErrorMessage = "Campo NOME obrigatório!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Campo E-MAIL obrigatório!")]
        [EmailAddress(ErrorMessage = "Campo E-MAIL inválido!")]
        public string Email { get; set; }
        public Address Address { get; set; }

        [Required]
        public DateTime RegistrationDate { get; set; } = DateTime.Now;

        [Required]
        [DefaultValue(true)]
        public Boolean status { get; set; }

    }
}
