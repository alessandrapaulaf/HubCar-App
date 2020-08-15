using Hubcar.Domain.HubcarDbContext;
using Hubcar.Domain.Models;
using System;

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
            throw new NotImplementedException();
        }
    }
}
