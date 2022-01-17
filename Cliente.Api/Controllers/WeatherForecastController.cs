using Cliente.Api.Classe;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cliente.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet("mostrar temperatura")]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("listar nome")]
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

            var retornabanco = classe.ListarPratos();

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

         


    }
}
