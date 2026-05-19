using Microsoft.AspNetCore.Mvc;
using WebApiBiblioteca.DTOs;
using WebApiBiblioteca.Services.Interfaces;

namespace WebApiBiblioteca.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : Controller
    {
        private readonly IClienteService _service;
        public ClienteController(IClienteService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClienteDto>>> ListaTodos()
        {
            var clientes = await _service.ObterTodosAsync();

        }
    }
}
