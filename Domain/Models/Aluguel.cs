using System;
using System.Collections.Generic;

namespace Hubcar.Domain.Models
{
    public partial class Aluguel
    {
        public int Id { get; }
        public DateTime DataRetirada { get; set; }
        public DateTime? DataEntrega { get; set; }
        public string LocalRetirada { get; set; }
        public int? AvaliacaoId { get; }
        public int? CarroId { get; }
        public int UsuarioId { get; set; }
        public virtual Avaliacao Avaliacao { get; set; }
        public virtual Carro Carro { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
