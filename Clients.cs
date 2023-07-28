namespace AngelicasSorullos.Data
{
    public class Clients
    {

        public int Id { get; set; }
        public string ClientName { get; set; }
        public string Address { get; set; }
        public ICollection<Orders> Orders { get; set; }
    }
}
