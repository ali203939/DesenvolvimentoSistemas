namespace WebApiExemploBiblioteca.Entities
{
    public class AudioBook : Livro
    {
        public string Narrador { get; set; }
        public int DuracaoMin { get; set; }

        public override DateTime CalcularPrazo()
        {
            return DateTime.Now.AddDays(10);
        }
    }
}
