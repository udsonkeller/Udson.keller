        
using Produto.Api.Entidade;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Produto.Api.Classe;

namespace Produto.Api.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("ListaProduto")]
        public List<string> listaproduto()
        {
            var listaproduto = new List<string>();
            listaproduto.Add("Coca-Cola");
            listaproduto.Add("Guarana Antartica");
            listaproduto.Add("H20- Limoneto");
            listaproduto.Add("Agua");
            listaproduto.Add("Monster");
            listaproduto.Add("TNT");
            listaproduto.Add("REDBULL");

            return listaproduto;
        }

        [HttpPost("CadastroProduto")]
        public List<Produtos> CadastroProduto (Produtos produtos)
        {
            var listaCadastroProdutos = new List<Produtos>();
            listaCadastroProdutos.Add(new Produtos
            {
                Id = produtos.Id,
                preco = produtos.preco,
                descricao = produtos.descricao,
                marca = produtos.marca,
                quantidade = produtos.quantidade,
                tipo = produtos.tipo
            });
            return listaCadastroProdutos;

        }
        [HttpGet("ListaProdutosFiltro")]
        public List<string> ListaProdutosFiltro(string filtroprodutos)
        {
            var classeprodutos = new ListaProdutos();
            var retornaprodutos = classeprodutos.ListaProdutos1();

            if (filtroprodutos == null)
            {
                return retornaprodutos;
            }
            else
            {
                var retornafiltro = retornaprodutos.Where(x => x.Contains(filtroprodutos));
                return retornafiltro.ToList();
            }

        }   
            

    }

}
