using Hubcar.Domain.HubcarDbContext;
using Hubcar.Domain.Models;

namespace Hubcar.Domain.AppServices
{
    public class UsuarioServices
    {
        HubcarDBContext _context;

        public UsuarioServices(HubcarDBContext context)
        {
            _context = context;
        }

        public Usuario ObterUsuarioLogado()
        {
            var logado = _context.UsuarioLogado.Find(1);
            var usuario = _context.Usuario.Find(logado.UsuarioId);

            return usuario;
        }
    }
}
