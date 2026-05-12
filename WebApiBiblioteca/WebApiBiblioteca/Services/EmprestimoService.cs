using WebApiBiblioteca.Models;
using WebApiBiblioteca.Services.Interfaces;

namespace WebApiBiblioteca.Services
{
    public class EmprestimoService : IEmprestimoService
    {
        public Task<bool> DevolverLivroAsync(int emprestimoId)
        {
            throw new NotImplementedException();
        }

        public Task<Emprestimo> RealizarEmprestimoAsync(int livroId, int clienteId)
        {
            throw new NotImplementedException();
        }
    }
}
