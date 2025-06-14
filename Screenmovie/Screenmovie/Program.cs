
using Screenmovie.Models;

using (HttpClient client = new HttpClient())

    try
    {
        string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
        var filmes = System.Text.Json.JsonSerializer.Deserialize<List<Filme>>(resposta);

        filmes[0].ExibirDetalhesDoFilme();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
