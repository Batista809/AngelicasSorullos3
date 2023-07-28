global using AngelicasSorullos.Models;

namespace AngelicasSorullos.Models
{
    public class Clients
    {
        public int Id { get; set; }
        public string? ClientName { get; set; }
        public string? Address { get; set; }
        public Order Class { get; set; } = Order.Sorullos;
    }
}
