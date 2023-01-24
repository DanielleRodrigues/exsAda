/*Crie uma classe Time que tenha como propriedade o nome do país, 
nome do esporte e a pontuação dele em um torneio. 
Sua pontuação pode ser acrescida por um método pontua que recebe como parâmetro
"W" para vitória (+3 pontos), 
"L" para derrota (+0 pontos) e 
"D" para empate (+1 ponto). */
using System;
class Time
{
    public string Pais { get; set; }
    public string Esporte { get; set; }
    public int Pontuacao { get; set; }

    public void Pontua(string resultado)
    {
        if (resultado == "W")
        {
            Pontuacao += 3;
        }
        else if (resultado == "L")
        {
            Pontuacao += 0;
        }
        else if (resultado == "D")
        {
            Pontuacao += 1;
        }

        Time brasil = new Time();
        brasil.Pais = "Brasil";
        brasil.Esporte = "Futebol";
        brasil.Pontua("W");
        Console.WriteLine("País: " + brasil.Pais);
        Console.WriteLine("Esporte: " + brasil.Esporte);
        Console.WriteLine("Pontuação: " + brasil.Pontuacao);
    }
}