
namespace Hubcar.Domain.Models
{
    public class UsuarioLogado
    {
        public int Id { get; protected set; }
        public int UsuarioId { get; protected set; }
        public Usuario Usuario { get; set; }
    }
}
