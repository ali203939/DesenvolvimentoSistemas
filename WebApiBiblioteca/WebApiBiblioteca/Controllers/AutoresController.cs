using Microsoft.AspNetCore.Mvc;

namespace WebApiBiblioteca.Controllers
{
    public class AutoresController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
