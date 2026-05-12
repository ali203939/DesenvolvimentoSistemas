using WebApiBiblioteca.Models;

namespace WebApiBiblioteca.Services.Interfaces
{
    public interface ILivroService
    {
        Task<IEnumerable<Livro>> ObterTodosAsync();
        Task<Livro> ObterPorIdAsync(int id);
        Task<Livro> InserirAsync(Livro livro);
        Task<bool> AtualizarAsync(Livro livro);
        Task<bool> ExcluirAsync(int id);
    }
}
