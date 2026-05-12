using WebApiBiblioteca.Models;

namespace WebApiBiblioteca.Services.Interfaces
{
    public interface IEmprestimoService
    {
        Task<Emprestimo> RealizarEmprestimoAsync(int livroId, int clienteId);
        Task<bool> DevolverLivroAsync(int emprestimoId);
    }
}
