using Microsoft.AspNetCore.Mvc;

namespace WebApiBiblioteca.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
