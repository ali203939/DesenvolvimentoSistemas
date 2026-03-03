using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApiExemploBiblioteca.Entities;

namespace WebApiExemploBiblioteca.Controllers
{
    public class UsuarioController : Controller
    {
        [HttpGet("MostrarUsuario")]
        public string MostrarUsuario(int idUsuario, string nomeUsuario)
        {
            Usuario usuario = new Usuario();
            usuario.Nome = nomeUsuario;
            usuario.Id1 = idUsuario;
            string resultado = $"Usuário : {usuario.Id1} \r\nNome : {usuario.Nome}";

            return resultado;
        }
    }
}
