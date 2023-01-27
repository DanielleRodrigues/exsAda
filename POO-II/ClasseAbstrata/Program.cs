class Program
{
static void Main(string[] args)
{
    Motorola moto = new Motorola("66666666", "Moto G8", "89556789012345", 32);
    moto.ligar();
    moto.instalarAplicativo("iPuke");
    Iphone iphone = new Iphone("066667654321", "Iphone 14 Plus", "098765432109876", 64);
    iphone.receberLigacao();
    iphone.instalarAplicativo("Marvel Snap");

}
}



