using Domain;
using System.Data.Entity;

namespace Hubcar.DataBase
{
    public class HubcarDbContext : DbContext 
    {
        public HubcarDbContext() : base("Name=HubcarDB")
        {
            Database.SetInitializer<HubcarDbContext>(
                new CreateDatabaseIfNotExists<HubcarDbContext>());
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Aluguel> Aluguel { get; set; }
        public DbSet<Carro> Carro { get; set; }
        public DbSet<Carteira> Carteira { get; set; }
        public DbSet<Avaliacao> Avaliacao { get; set; }
    }
}
