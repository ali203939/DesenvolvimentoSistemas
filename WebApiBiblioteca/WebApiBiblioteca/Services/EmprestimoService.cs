using WebApiBiblioteca.Data;
using WebApiBiblioteca.Models;
using WebApiBiblioteca.Services.Interfaces;

namespace WebApiBiblioteca.Services
{
    public class EmprestimoService : IEmprestimoService
    {
        private readonly BibliotecaSQLServerDbContext _context;

        public EmprestimoService(BibliotecaSQLServerDbContext context)
        {
            _context = context;
        }
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
