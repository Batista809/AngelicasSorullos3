using Microsoft.AspNetCore.Mvc;

namespace AngelicasSorullos.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
