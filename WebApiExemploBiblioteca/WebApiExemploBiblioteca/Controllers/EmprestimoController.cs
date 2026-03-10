using Microsoft.AspNetCore.Mvc;
using WebApiExemploBiblioteca.Entities;
namespace WebApiExemploBiblioteca.Controllers
{
    public class EmprestimoController : Controller
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
    }
}
