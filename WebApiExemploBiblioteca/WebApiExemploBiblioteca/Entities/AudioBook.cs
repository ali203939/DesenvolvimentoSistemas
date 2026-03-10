namespace WebApiExemploBiblioteca.Entities
{
    public class AudioBook : Livro
    {
        public string Narrador { get; set; }
        public int DuracaoMin { get; set; }
    }
}
