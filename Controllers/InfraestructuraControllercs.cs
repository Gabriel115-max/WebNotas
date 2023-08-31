using Microsoft.AspNetCore.Mvc;

namespace WebNotas.Controllers
{
    public class InfraestructuraController : Controller
    {
        public IActionResult Index()
        {
            return View("Folleto");
        }

        public IActionResult Folleto()
        {
            return View();
        }

        public IActionResult Primero()
        {
            ViewData["Año"] = "Primer Año";
            return View("Materias");
        }

        public IActionResult Segundo()
        {
            ViewData["Año"] = "Segundo Año";
            return View("Materias");
        }

        public IActionResult Tercero()
        {
            ViewData["Año"] = "Tercer Año";
            return View("Materias");
        }
    }


}
