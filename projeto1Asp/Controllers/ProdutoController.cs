using Microsoft.AspNetCore.Mvc;

namespace projeto1Asp.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Produto()
        {
            return View();
        }
    }
}
