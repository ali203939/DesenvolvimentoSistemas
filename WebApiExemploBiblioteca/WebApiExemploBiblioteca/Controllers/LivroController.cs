using Microsoft.AspNetCore.Mvc;
using WebApiExemploBiblioteca.Entities;
namespace WebApiExemploBiblioteca.Controllers
{
    public class LivroController : Controller
    {
        [HttpGet("MostrarLivro")]
        public string MostrarLivro(int Id, string titulo)
        {
            Livro livro = new Livro();
            livro.Id = Id;
            livro.Titulo = titulo;
            string resultado = $"Livro: {livro.Titulo} \r\nId: {livro.Id}";
            return resultado;
        }
    }
}
