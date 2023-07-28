using Microsoft.EntityFrameworkCore;


namespace AngelicasSorullos.Data
{
    public class ClientStoreContext: DbContext
    {
        public ClientStoreContext(DbContextOptions<ClientStoreContext> options): base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\MMSQL2016;Database=AngelicasSorullos;Trusted_Connection=true;TrustServerCertificate=true;");
        }
        public DbSet<Clients> ClientId { get; set; }
    }
}
