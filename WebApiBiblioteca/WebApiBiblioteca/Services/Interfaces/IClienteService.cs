using WebApiBiblioteca.Models;

namespace WebApiBiblioteca.Services.Interfaces
{
    public interface IClienteService
    {
        Task<IEnumerable<Cliente>> ObterTodosAsync();
        Task<Cliente> ObterPorIdAsync(int id);
        Task<Cliente> InserirAsync(Cliente cliente);
        Task<bool> AtualizarAsync(Cliente cliente);
        Task<bool> ExcluirAsync(int id);
    }
}
