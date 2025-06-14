using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Screenmovie.Models
{
    internal class Filme
    {
        [JsonPropertyName("title")]
        public string Nome { get; set; }

        [JsonPropertyName("year")]
        public string Ano { get; set; }


        [JsonPropertyName("imDbRating")]
        public string Nota { get; set; }

        public void ExibirDetalhesDoFilme()
        {
            Console.WriteLine($"Titulo: {Nome}");
            Console.WriteLine($"Ano de lançamento: {Ano}");
            Console.WriteLine($"Nota no imDb: {Nota}");

        }
    }

}
