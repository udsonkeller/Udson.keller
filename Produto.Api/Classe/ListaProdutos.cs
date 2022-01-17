using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Produto.Api.Classe
{
    public class ListaProdutos
    {
        public List<string> ListaProdutos1()
        {
            var produto = new List<string>();

            produto.Add("Coca-Cola 600 ml");
            produto.Add("Coca-Cola 350 ml");
            produto.Add("Coca-Cola 1L");
            produto.Add("RedBull");
            produto.Add("RedBull Diet");
            produto.Add("Monster");
            produto.Add("Monster Diet");
            produto.Add("Guarana Antartica 2L");
            produto.Add("Guarana Antartica 1L");
            produto.Add("Guarana Antartica 350ml");
            produto.Add("Fanta Laranja 350 ml");
            produto.Add("H2O limoneto 350ml");

            return produto;
        }



    }
}
