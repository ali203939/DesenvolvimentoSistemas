
namespace WebApiExemploBiblioteca.Entities
{
    public class LivroFisico : Livro
    {
        public string Corredor { get; set; }

        public override DateTime CalcularPrazo()
        {
            return DateTime.Now.AddDays(7);
        }
    }
}
