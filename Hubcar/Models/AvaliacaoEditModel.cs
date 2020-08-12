using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hubcar.Portal.Web.Models
{
    public class AvaliacaoEditModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int? Nota { get; set; }
        public int AluguelId { get; set; }
    }
}
