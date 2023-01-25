using FitnessApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace FitnessApp.Controllers
{
    public class AppController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public AppController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Inicio()
        {
            return View();
        }

        public IActionResult Registrar()
        {
            return View();
        }

        public IActionResult Ejercicios()
        {
            return View();
        }

        public IActionResult Rutina()
        {
            return View();
        }
        public IActionResult RevisarEjercicios()
        {
            return View();
        }

         public IActionResult DatosEjercicio()
        {
        return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
