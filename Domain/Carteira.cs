using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain
{
    [Table("Carteira")]
    public class Carteira
    {
        public int Id { get; }
        public decimal Saldo { get; set; }
        public Usuario Usuario { get; set; }
    }
}
