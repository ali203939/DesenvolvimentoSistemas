using WebApiBiblioteca.Models;
using WebApiBiblioteca.Services.Interfaces;

namespace WebApiBiblioteca.Services
{
    public class ClienteService : IClienteService
    {
        public Task<bool> AtualizarAsync(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExcluirAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> InserirAsync(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> ObterPorIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Cliente>> ObterTodosAsync()
        {
            throw new NotImplementedException();
        }
    }
}