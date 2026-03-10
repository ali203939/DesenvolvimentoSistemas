using Microsoft.AspNetCore.Mvc;
using WebApiExemploBiblioteca.Entities;
namespace WebApiExemploBiblioteca.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LivroController : ControllerBase
    {
        [HttpGet("MostrarLivro")]
        public string MostrarLivro(int Id, string titulo)
        {
            LivroFisico livro = new LivroFisico();
            livro.Id = Id;
            livro.Titulo = titulo;
            string resultado = $"Livro: {livro.Titulo} \r\nId: {livro.Id}";
            return resultado;
        }

        [HttpPost("MostrarLivroFisicoJSON")]
        public IActionResult MostrarLivroFisicoJson(int idLivroUsuario, string tituloLivroUsuario, string autorLivroUsuario, string editoraLivroUsuario, DateTime dataPublicacaoLivro, string corredorLivro)
        {
            LivroFisico livro = new LivroFisico();
            livro.Id = idLivroUsuario;
            livro.Titulo = tituloLivroUsuario;
            livro.Autor = autorLivroUsuario;
            livro.Editora = editoraLivroUsuario;
            livro.DataPublicacao = dataPublicacaoLivro;
            livro.Corredor = corredorLivro;
            return Ok(livro);
        }

        [HttpPost("MostrarLivroAudioBookJSON")]
        public IActionResult MostrarLivroAudioBookJson(int idLivroUsuario, string tituloLivroUsuario, string autorLivroUsuario, string editoraLivroUsuario, DateTime dataPublicacaoLivro, string narrador, int duracaoMin)
        {
            AudioBook audioBook = new AudioBook();
            audioBook.Id = idLivroUsuario;
            audioBook.Titulo = tituloLivroUsuario;
            audioBook.Autor = autorLivroUsuario;
            audioBook.Editora = editoraLivroUsuario;
            audioBook.DataPublicacao = dataPublicacaoLivro;
            audioBook.Narrador = narrador;
            audioBook.DuracaoMin = duracaoMin;
            return Ok(audioBook);
        }


        [HttpPost("MostrarLivroEbookJSON")]
        public IActionResult MostrarLivroEbookJson(int idLivroUsuario, string tituloLivroUsuario, string autorLivroUsuario, string editoraLivroUsuario, DateTime dataPublicacaoLivro, string urlDownload)
        {
            Ebook ebook = new Ebook();
            ebook.Id = idLivroUsuario;
            ebook.Titulo = tituloLivroUsuario;
            ebook.Autor = autorLivroUsuario;
            ebook.Editora = editoraLivroUsuario;
            ebook.DataPublicacao = dataPublicacaoLivro;
            ebook.UrlDownload = urlDownload;

            return Ok(ebook);
        }
    }
}