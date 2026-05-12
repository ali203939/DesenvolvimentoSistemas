using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiBiblioteca.Models
{
    public class Livro
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string Titulo { get; set; } = string.Empty;

        [Required]
        [MaxLength(13)]
        public string ISBN { get; set; } = string.Empty;

        public int? AnoPublicacao { get; set; }

        public bool Disponivel { get; set; } = true;

        [Required]
        public int AutorId { get; set; }

        [ForeignKey(nameof(AutorId))]
        public Autor? Autor { get; set; }

        public ICollection<Emprestimo> Emprestimos { get; set; }
            = new List<Emprestimo>();
    }
}
