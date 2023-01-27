class Iphone : Smartphone
{
public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) { }

public override void instalarAplicativo(string nome)
{
    Console.WriteLine("Instalando aplicativo " + nome + " no Iphone.");
}
}