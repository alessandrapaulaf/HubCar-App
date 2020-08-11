using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    [Table("Usuario")]
    public class Usuario
    {
        public int Id { get; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }

    }
}
