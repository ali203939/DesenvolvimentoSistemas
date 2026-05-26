using System.ComponentModel.DataAnnotations;

namespace WebApiBiblioteca.DTOs
{
    public class ClienteDto
    {
        [Required(ErrorMessage = "Nome é obrigatório")]
        [MaxLength(150)]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email é obrigatório")]
        [MaxLength(200)]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; } = string.Empty;

        [MaxLength(20)]
        public string? Telefone { get; set; }

        public bool? Ativo { get; set; } = true;
    }
}
