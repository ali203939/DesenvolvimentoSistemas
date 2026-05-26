using System.ComponentModel.DataAnnotations;

namespace WebApiBiblioteca.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        [MaxLength(150)]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email é obrigatório")]
        [MaxLength(200)]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; } = string.Empty;

        [MaxLength(20)]
        public string? Telefone { get; set; }

        public DateTime DataCadastro { get; set; } = DateTime.UtcNow;

        public bool? Ativo { get; set; } = true;

        // Navegação: um Cliente pode ter muitos Empréstimos
        public ICollection<Emprestimo> Emprestimos { get; set; } = new List<Emprestimo>();
    }
}
