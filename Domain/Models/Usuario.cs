using System;
using System.Collections.Generic;

namespace Hubcar.Domain.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Carro = new HashSet<Carro>();
            Aluguel = new HashSet<Aluguel>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }

        public virtual ICollection<Carro> Carro { get; set; }
        public virtual Carteira Carteira { get; set; }
        public virtual ICollection<Aluguel> Aluguel { get; set; }
        public virtual UsuarioLogado UsuarioLogado { get; set; }
    }
}
