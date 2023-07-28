using Microsoft.AspNetCore.Mvc;

namespace AngelicasSorullos.Models
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : ControllerBase
    {
        private static Order Sorullos = new Order();

        public IActionResult Get()
        {
            return Ok(Sorullos);
        }
    }
}
