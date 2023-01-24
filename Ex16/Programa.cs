/*
Construa uma classe Programa com as propriedades duracao e generos (ação, comédia, suspense, drama, terror) e duas classes que herdam desta (Seriado e Filme). A classe Seriado deve ter numeroDeEpisodios (de 1 a n), anoDeInicio e anoDeFim. Já a classe Filme precisa ter a duracao (em minutos).*/
using System;
class Programa
{
    public int Duracao { get; set; }
    public List<string> Generos { get; set; }

    public Programa(int duracao, List<string> generos)
    {
        Duracao = duracao;
        Generos = generos;
    }

    /*
    List<string> generos = new List<string> { "Ação", "Suspense" };
    Seriado seriado = new Seriado(50, generos, 100, 2010, 2020);
    Filme filme = new Filme(120, generos);

    Console.WriteLine("Duração do seriado: " + seriado.Duracao);
    Console.WriteLine("Gêneros do seriado: " + string.Join(", ", seriado.Generos));
    Console.WriteLine("Número de episódios do seriado: " + seriado.NumeroDeEpisodios);
    Console.WriteLine("Ano de início do seriado: " + seriado.AnoDeInicio);
    Console.WriteLine("Ano de fim do seriado: " + seriado.AnoDeFim);
    Console.WriteLine("Duração do filme: " + filme.Duracao);
    Console.WriteLine("Gêneros do filme: " + string.Join(", ", filme.Generos));
    */
}