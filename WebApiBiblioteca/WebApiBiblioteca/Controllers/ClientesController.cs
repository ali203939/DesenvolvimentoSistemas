using Microsoft.AspNetCore.Mvc;
using WebApiBiblioteca.DTOs;
using WebApiBiblioteca.Models;
using WebApiBiblioteca.Services.Interfaces;

namespace WebApiBiblioteca.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteService _service;
        public ClientesController(IClienteService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> ListaTodos()
        {
            var clientes = await _service.ObterTodosAsync();
            return Ok(clientes);

        }
        // get: api/clientes/id
        [HttpGet("{id:int}")]
        public async Task<IActionResult> ListarPorId(int id)
        {
            var clientes = await _service.ObterPorIdAsync(id);
            if(clientes is null)
            {
                return NotFound(new {mensagem = $"Cliente com Id {id} não encontrado."});
            }
            return Ok(clientes);

        }

        ///put: api/clientes/{id}
        [HttpPost]
        public async Task<IActionResult> ListarPorId([FromBody] ClienteDto clienteDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var cliente = new Cliente
            {
                Nome = clienteDto.Nome,
                Email = clienteDto.Email,
                Telefone = clienteDto.Telefone,
                Ativo = clienteDto.Ativo
            };
            var clienteCriado = await _service.InserirAsync(cliente);
            return CreatedAtAction(nameof(ListarPorId), new { id = clienteCriado.Id }, clienteCriado);
        }

        //// PUT: api/clientes/{id}
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Alterar(int id, [FromBody] ClienteDto clienteDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var cliente = new Cliente
            {
                Id = id,
                Nome = clienteDto.Nome,
                Email = clienteDto.Email,
                Telefone = clienteDto.Telefone,
                Ativo = clienteDto.Ativo
            };

            var atualizado = await _service.AtualizarAsync(cliente);
            if (!atualizado)
                return NotFound(new { mensagem = $"Cliente com Id {id} não encontrado." });

            return NoContent();
        }


        // DELETE: api/clientes/{id}
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Excluir(int id)
        {
            var excluido = await _service.ExcluirAsync(id);
            if (!excluido)
                return NotFound(new { mensagem = $"Cliente com Id {id} não encontrado." });

            return NoContent();
        }
    }
}