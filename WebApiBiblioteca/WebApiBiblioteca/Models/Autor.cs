using System.ComponentModel.DataAnnotations;

namespace WebApiBiblioteca.Models
{
    public class Autor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string Nome { get; set; }
        public string Nacionalidade { get; set; }
        public DateTime DataNascimento { get; set; }
        public ICollection<Livro> Livros { get; set; } = new List<Livro>();

    }
}
