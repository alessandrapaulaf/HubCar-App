using System;
using System.Collections.Generic;

namespace Hubcar.Domain.Models
{
    public partial class Carteira
    {
        public int Id { get; set; }
        public decimal? Saldo { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
