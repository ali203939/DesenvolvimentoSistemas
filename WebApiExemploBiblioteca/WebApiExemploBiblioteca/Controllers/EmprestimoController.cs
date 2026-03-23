using Microsoft.AspNetCore.Mvc;
using WebApiExemploBiblioteca.Entities;
namespace WebApiExemploBiblioteca.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmprestimoController : ControllerBase
    {
        [HttpGet("MostrarEmprestimo")]
        public string MostrarEmprestimo(int id, int idCliente, int idLivro, DateTime dataEmprestimo)
        {
            Emprestimo emprestimo = new Emprestimo();
            emprestimo.Id = id;
            emprestimo.IdCliente = idCliente;
            emprestimo.IdLivro = idLivro;
            emprestimo.DataEmprestimo = dataEmprestimo;

            string resultado = $"Id: {emprestimo.Id}, IdCliente: {emprestimo.IdCliente}, IdLivro: {emprestimo.IdLivro}, DataEmprestimo: {emprestimo.DataEmprestimo}";
            return resultado;
        }

        [HttpPost("RealizarEmprestimo")]
        public IActionResult RealizarEmprestimo(int id, int idCliente, int idLivro, DateTime dataEmprestimo, int tipoLivro)
        {
            Emprestimo emprestimo = new Emprestimo();
            emprestimo.Id = id;
            emprestimo.IdCliente = idCliente;
            emprestimo.IdLivro = idLivro;
            emprestimo.DataEmprestimo = dataEmprestimo;

            switch (tipoLivro)
            {
                case 1:
                    LivroFisico livroFisico = new LivroFisico();
                    emprestimo.DataEntrega = livroFisico.CalcularPrazo();
                    break;
                case 2:
                    Ebook ebook = new Ebook();
                    emprestimo.DataEntrega = ebook.CalcularPrazo();
                    break;
                case 3:
                    AudioBook audioBook = new AudioBook();
                    emprestimo.DataEntrega = audioBook.CalcularPrazo();
                    break;
                default:
                    return BadRequest("Tipo de livro inválido. Use 1 para Livro Físico, 2 para Ebook ou 3 para Audiobook.");
            }

            return Ok(emprestimo);
        }
    }
}
