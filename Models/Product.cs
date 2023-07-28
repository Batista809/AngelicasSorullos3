namespace AngelicasSorullos.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public int ClientId { get; set; }
   
        public Orders? Orders { get; set; }
    }
}
