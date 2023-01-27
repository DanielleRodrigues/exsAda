class Cisne : Ave, IOviparo
{
    public bool TemPenasBrancas { get; set; }

    public Cisne()
    {
        Rapina = false;
        CorPena = "Branca";
    }

    public void Botar()
    {
        Console.WriteLine("Colocando ovos...");
    }

    public void Chocar()
    {
        Console.WriteLine("Chocando ovos...");
    }
}
