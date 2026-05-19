using WebApiBiblioteca.Data;
using WebApiBiblioteca.Models;
using WebApiBiblioteca.Services.Interfaces;

namespace WebApiBiblioteca.Services
{
    public class LivroService : ILivroService
    {
        private readonly BibliotecaSQLServerDbContext _context;

        public LivroService(BibliotecaSQLServerDbContext context)
        {
            _context = context;
        }
        public Task<bool> AtualizarAsync(Livro livro)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExcluirAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Livro> InserirAsync(Livro livro)
        {
            throw new NotImplementedException();
        }

        public Task<Livro> ObterPorIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Livro>> ObterTodosAsync()
        {
            throw new NotImplementedException();
        }
    }
}
