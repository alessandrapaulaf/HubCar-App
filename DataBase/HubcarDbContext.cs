using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Hubcar.DataBase
{
    public class HubcarDbContext : DbContext 
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Aluguel> Aluguel { get; set; }
        public DbSet<Carro> Carro { get; set; }
        public DbSet<Carteira> Carteira { get; set; }
        public DbSet<Avaliacao> Avaliacao { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=localhost;Database=piloto_hubcar;User Id=sa;Password=123456;");
    }
}
