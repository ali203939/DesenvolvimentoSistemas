using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApiExemploBiblioteca.Entities;

namespace WebApiExemploBiblioteca.Controllers

{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("MostrarUsuario")]
        public string MostrarUsuario(int idUsuario, string nomeUsuario, string cpfUsuario, string enderecoUsuario, string cidadeUsuario, string telefoneUsuario)

        {
            Usuario usuario = new Usuario();
            usuario.Nome = nomeUsuario;
            usuario.Id = idUsuario;
            usuario.Cpf = cpfUsuario;
            usuario.Endereco = enderecoUsuario;
            usuario.Cidade = cidadeUsuario;
            usuario.TelefoneCelular = telefoneUsuario;
            string resultado = $"Usuário : {usuario.Id} \r\nNome : {usuario.Nome} \r\nCpf: {usuario.Cpf} " +
                $"\r\nEndereco: {usuario.Endereco}  \r\nCidade: {usuario.Cidade} \r\nTelefone: {usuario.TelefoneCelular}";

            return resultado;
        }



        [HttpGet("MostrarUsuarioJSON")]
        public IActionResult MostrarUsuarioJson(int idUsuario, string nomeUsuario, string cpfUsuario, string enderecoUsuario, string cidadeUsuario, string telefoneUsuario)
        {
            Usuario usuario = new Usuario();
            usuario.Nome = nomeUsuario;
            usuario.Id = idUsuario;
            usuario.Cpf = cpfUsuario;
            usuario.Endereco = enderecoUsuario;
            usuario.Cidade = cidadeUsuario;
            usuario.TelefoneCelular = telefoneUsuario;
            return Ok(usuario);
        }
    }
}
