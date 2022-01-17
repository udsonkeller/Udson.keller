using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cliente.Api.Classe
{
    public class DadosBanco
    {
       public List<string> ListarPratos()
        {
            var nomepratos = new List<string>();
            nomepratos.Add("Arroz com Galinha");
            nomepratos.Add("Arroz com Carne e Fritas");
            nomepratos.Add("Macarrao a Bolonhesa");
            nomepratos.Add("Macarrão ao Sugo");
            nomepratos.Add("Arroz com Parmegiana");
            nomepratos.Add("Comida Caseira");

            return nomepratos;

        }


        public List<string> ListaNome()
        {
            var listaNomes = new List<string>();
            listaNomes.Add("Leandro Toscão de Almeida");
            listaNomes.Add("Patricia Maria França de Oliveira");
            listaNomes.Add("Ana Paula Teixeira Alves");
            listaNomes.Add("Gabriel Keller faria de Oliveira");
            listaNomes.Add("Daniel Keller Teixeira de Oliveira");
            listaNomes.Add("Lais Maria Campos");
            listaNomes.Add("Jose Roberto da silva");
            listaNomes.Add("Lewis Carl Davidson Hamilton ");
            listaNomes.Add("Kimi Matias Raikkonen");

            return listaNomes;
        
        
        }
    }
}
