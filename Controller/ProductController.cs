using Microsoft.AspNetCore.Mvc;

namespace AngelicasSorullos.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
