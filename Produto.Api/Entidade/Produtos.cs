using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Produto.Api.Entidade
{
    public class Produtos
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public decimal preco { get; set; }
        public string tipo { get; set; }
        public string descricao { get; set; }
        public string marca { get; set; }
        public int quantidade { get; set; }
    }
}
