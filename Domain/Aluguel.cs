using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    [Table("Aluguel")]
    public class Aluguel
    {
        public int Id { get; }
        public DateTime DataRetirada { get; set; }
        public DateTime DataEntrega { get; set; }
        public string LocalRetirada { get; set; }
        public Carro Carro { get; set; }
        public Avaliacao Avaliacao { get; set; }
    }
}
