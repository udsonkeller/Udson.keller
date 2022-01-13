
using Cliente.Api.Classe;
using Cliente.Api.Entidade;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Cliente.Api.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();

        }

        [HttpGet("listarnome")]
        public List<string> listarnome()
        {
            var lista = new List<string>();
            lista.Add("cardapio");
            lista.Add("Refrigerante");
            lista.Add("Sobremesa");
            return lista;

        }

        [HttpGet("NomePratos")]
        public List<string> NomePratos(string filtro)
        {
            var classe = new DadosBanco();

            var retornabanco = classe.dadosbanco();

            if (filtro == null)
            {
                return retornabanco;

            }
            else
            {
                var retorno = retornabanco.Where(x => x.Contains(filtro));
                return retorno.ToList();

            }

           
        }


        [HttpPost("Cadastro")]

        public List<string> adicionarcliente(string nome, string endereço, string telefone, int idade)
        {
            var ListadeCadastro = new List<string>();
            ListadeCadastro.Add(nome);
            ListadeCadastro.Add(endereço);
            ListadeCadastro.Add(telefone);
            ListadeCadastro.Add(idade.ToString());

            return ListadeCadastro;
        }


        [HttpGet("ListarCliente")]

        public List<Clientes> ListarCliente()
        {
            var listaCliente = new List<Clientes>();

            listaCliente.Add(new Clientes 
            {
                Nome = " Leandro Toscao de Almeita " ,
                Endereco = " Rua Odilon jose de Almeida, nº204",
                Complemento = " casa",
                Email = "leandro.tosco@hotmail.com",
                Sexo = " M ",
                Telefone = "1137158457"   
            
            });

            listaCliente.Add(new Clientes
            {
                Nome = " Lewis Carl Davidson Hamilton ",
                Endereco = " Rua Eurides de Faria, n 45",
                Complemento = " casa",
                Email = "lewis.hamilton@hotmail.com",
                Sexo = " M ",
                Telefone = "1125748585"
            });

            return listaCliente;



        }


        [HttpPost("CadastroCliente")]

        public List<Clientes> CadastroClientes(Clientes clientes) 
        {
            var ListaCadastroCliente = new List<Clientes>();
            ListaCadastroCliente.Add(new Clientes 
            { 
              Nome = clientes.Nome,
              Endereco = clientes.Endereco,
              Complemento = clientes.Complemento,
              Email = clientes.Email,
              Sexo = clientes.Sexo,
              Telefone = clientes.Telefone   
                         
                
             });
            return ListaCadastroCliente;

        }
    }




}


