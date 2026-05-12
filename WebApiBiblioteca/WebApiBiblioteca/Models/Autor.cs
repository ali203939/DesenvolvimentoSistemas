using System.ComponentModel.DataAnnotations;

namespace WebApiBiblioteca.Models
{
    public class Autor
    {
        public int Id { get; set; }
        [Required][MaxLength(150)]
        public string Nome { get; set; }
        [MaxLength(100)]
        public string? Nacionalidade { get; set; }
        public DateTime DataNascimento { get; set; }
        public ICollection<Livro> Livros { get; set; } = new List<Livro>();

    }
}
