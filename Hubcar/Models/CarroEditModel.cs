using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hubcar.Portal.Web.Models
{
    public class CarroEditModel
    {
        public string Modelo { get; set; }
        public string Ano { get; set; }
        public string Placa { get; set; }
        public decimal ValorDiaria { get; set; }
    }
}
