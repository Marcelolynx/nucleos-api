using System.ComponentModel.DataAnnotations;

namespace NWA.Identidade.API.Models
{
    public class UsuarioRegistro
    {
        [Required(ErrorMessage = "O campo {0} obrigatorio.")]
        [EmailAddress(ErrorMessage = "O Campo {0} esta em formato invalido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo {0} obrigatorio")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 6)]
        public string Senha { get; set; }

        [Compare("Senha", ErrorMessage = "As senhas nao conferem.")]
        public string SenhaConfirmacao { get; set; }
    }

    public class UsuarioLogin
    {
        [Required(ErrorMessage ="O campo {0} e obrigatorio")]
        [EmailAddress(ErrorMessage = "O Campo {0} esta em formato invalido.")]
        public string Email { get; set; }

        [Required(ErrorMessage ="O campo e obrigatorio")]
        [StringLength (100, ErrorMessage ="O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength =6)]
        public string Senha { get; set; }
    }
}
