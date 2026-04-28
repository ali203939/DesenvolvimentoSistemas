using Microsoft.AspNetCore.Mvc;

namespace WebApiBiblioteca.Controllers
{
    public class EmprestimosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
