using System;
using System.Collections.Generic;

namespace Hubcar.Domain.Models
{
    public partial class Carro
    {
        public Carro()
        {
            Aluguel = new HashSet<Aluguel>();
        }

        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Ano { get; set; }
        public string Placa { get; set; }
        public decimal ValorDiaria { get; set; }

        public virtual Usuario Proprietario { get; set; }
        public virtual ICollection<Aluguel> Aluguel { get; set; }
    }
}
