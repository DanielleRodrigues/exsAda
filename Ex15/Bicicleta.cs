class Bicicleta : Veiculo
{
    public bool Infantil { get; set; }

    public Bicicleta(bool infantil, int rodas)
    {
        Infantil = infantil;
        if (rodas <= 2)
            Console.WriteLine("Uma bicicleta deve ter mais de 2 rodas");
        else
            Rodas = rodas;
    }
}