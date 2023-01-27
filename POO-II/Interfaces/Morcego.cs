class Morcego : Mamifero, IVoar
{
    public int AltitudeMaximaEmMetros { get; set; }
    public double VelocidadeDoVoo { get; set; }

    public Morcego()
    {
        QtdeDeMamas = 2;
        Pelos = true;
        Cordopelo = "Preto";
    }

    public void Voar()
    {
        Console.WriteLine("Flap flap flap!");
    }
}