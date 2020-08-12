using System;
using System.Collections.Generic;

namespace Hubcar.Domain.Models
{
    public class Avaliacao
    {
        public Avaliacao()
        {
            Aluguel = new HashSet<Aluguel>();
        }
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int? Nota { get; set; }
        public IEnumerable<Aluguel> Aluguel { get; set; }
    }
}
