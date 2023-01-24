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