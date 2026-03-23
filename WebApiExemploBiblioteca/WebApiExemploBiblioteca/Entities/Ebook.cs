namespace WebApiExemploBiblioteca.Entities
{
    public class Ebook : Livro
    {
        public string UrlDownload { get; set; }

        public override DateTime CalcularPrazo()
        {
            return DateTime.Now.AddDays(15);
        }
    }
}
