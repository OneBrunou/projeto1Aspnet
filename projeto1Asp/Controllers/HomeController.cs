using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using projeto1Asp.Models;

namespace projeto1Asp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //ViewBag = Armazena Dados
            ViewBag.NomeUsuario = "Brno";
            ViewBag.EmailUsuario = "ms2689992@gmail.com";
            ViewBag.NivelAcesso = "Usuario";
            ViewBag.DataAcesso = DateTime.Now.ToLongDateString();

            return View();
        }

        public IActionResult Sobre()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }
   
        public IActionResult Portifolio()
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
