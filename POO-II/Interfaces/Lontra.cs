class Lontra : Mamifero, IAquatico
{
    public bool ViveEmTerra { get; set; }
    public bool Mergulho { get; set; }
    public bool AguaDoce { get; set; }

    public Lontra()
    {
        QtdeDeMamas = 4;
        Pelos = true;
        Cordopelo = "Castanho";
        ViveEmTerra = true;
        Mergulho = true;
        AguaDoce = true;
    }

    public void Nadar()
    {
        Console.WriteLine("Nado nado nado!");
    }
}