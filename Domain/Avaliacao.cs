using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain
{
    [Table("Avaliacao")]
    public class Avaliacao
    {
        public int Id { get; }
        public string Descricao { get; set; }
        public int Nota { get; set; }

    }
}
