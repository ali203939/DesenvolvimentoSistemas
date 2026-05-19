using Microsoft.EntityFrameworkCore;
using WebApiBiblioteca.Data;
using WebApiBiblioteca.Models;
using WebApiBiblioteca.Services.Interfaces;

namespace WebApiBiblioteca.Services
{
    public class ClienteService : IClienteService
    {
        private readonly BibliotecaSQLServerDbContext _context;

        public ClienteService(BibliotecaSQLServerDbContext context)
        {
            _context = context;
        }

        public async Task<Cliente> ObterPorIdAsync(int id)
        {
            var cliente = await _context.Clientes.AsNoTracking()
            .FirstOrDefaultAsync(c => c.Id == id);
            return cliente;
        }

        public async Task<IEnumerable<Cliente>> ObterTodosAsync()
        {
            return await _context.Clientes.AsNoTracking().ToListAsync();
        }

        public async Task<bool> AtualizarAsync(Cliente cliente)
        {
            var existe = await _context.Clientes.AnyAsync(c => c.Id == cliente.Id);
            if ( !existe)
            {
                return false;
            }
            _context.Clientes.Update(cliente);
            await _context.SaveChangesAsync();
            return true;
            {
                
            }
        }

        public BibliotecaSQLServerDbContext Get_context()
        {
            return _context;
        }

        public async Task<bool> ExcluirAsync(int id)
        {
           var cliente = await _context.Clientes.FindAsync(id);
            if (cliente is null)
            {
                return false;
            }
            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Cliente> InserirAsync(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();
            return cliente;
        }

    }
}