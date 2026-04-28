using Microsoft.AspNetCore.Mvc;

namespace WebApiBiblioteca.Controllers
{
    public class LivrosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
