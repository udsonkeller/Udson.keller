using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cliente.Api.Entidade
{
    public class Clientes
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public string Telefone { get; set; }
        public  string Sexo { get; set; }
        public string Email { get; set; }

    }
}
