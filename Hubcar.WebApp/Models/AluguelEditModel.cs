using System;
using Hubcar.Domain.Models;


namespace Hubcar.Portal.Web.Models
{
    public class AluguelEditModel
    {
        public DateTime DataRetirada { get; set; }
        public DateTime? DataEntrega { get; set; }
        public string LocalRetirada { get; set; }
        public int CarroId { get; set; }
    }
}
