using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hubcar.Portal.Web.Models
{
    public class UsuarioEditModel
    {
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }

    }
}
