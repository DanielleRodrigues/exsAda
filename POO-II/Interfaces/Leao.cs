class Leao : Mamifero
{
    public bool CaudaComBarbas { get; set; }

    public Leao()
    {
        QtdeDeMamas = 2;
        Pelos = true;
        Cordopelo = "Amarelo";
    }

    public void Rugir()
    {
        Console.WriteLine("Rrrrrrrrrrrrrrr!");
    }
}