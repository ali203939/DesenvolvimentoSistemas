namespace WebApiExemploBiblioteca.Entities
{
    public abstract class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public DateTime DataPublicacao { get; set; }

    }
}
