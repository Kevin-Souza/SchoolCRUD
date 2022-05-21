using System.ComponentModel.DataAnnotations;

namespace TemplateBootstrap.Models
{

    public class funcionario
    {
        [Key]
        [Display(Name = "ID:")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Informe o nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage = "E-mail Inválido")]
        public string Email { get; set; }
    }
}