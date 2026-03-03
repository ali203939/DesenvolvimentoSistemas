using Microsoft.AspNetCore.Components.Web;

namespace WebApiExemploBiblioteca.Entities
{
    public class Emprestimo
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdLivro { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataEntrega { get; set; }
        public bool Entregue { get; set; } 
    }
}
