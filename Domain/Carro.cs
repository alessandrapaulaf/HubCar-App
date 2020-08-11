using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain
{
    [Table("Carro")]
    public class Carro
    {
        public int Id { get; }
        public string Modelo { get; set; }
        public string Ano { get; set; }
        public string Placa { get; set; }
        public decimal ValorDiaria { get; set; }
        public Usuario Proprietario { get; set; }
    }
}
