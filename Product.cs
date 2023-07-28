using Microsoft.Extensions.Hosting;

namespace AngelicasSorullos
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }

        public int ClientsId { get; set; }
       // public virtual Clients Clients { get; set; }

        public int OrderId { get; set; }
       // public virtual Order Order { get; set; }
    }
}
