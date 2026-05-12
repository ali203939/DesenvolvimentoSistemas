using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiBiblioteca.Models
{
    public class Emprestimo
    {
        public int Id { get; set; }

        // FK 1: qual livro foi emprestado
        [Required]
        public int LivroId { get; set; }

        [ForeignKey(nameof(LivroId))]
        public Livro? Livro { get; set; }

        // FK 2: quem pegou o livro
        [Required]
        public int ClienteId { get; set; }

        [ForeignKey(nameof(ClienteId))]
        public Cliente? Cliente { get; set; }

        public DateTime DataEmprestimo { get; set; } = DateTime.UtcNow;

        public DateTime? DataDevolucao { get; set; }

        public bool Devolvido { get; set; } = false;
    }
}
