/*Deseja-se montar uma classe Sorteio que tem o número de pessoas inscritas 
e um método sorteiaPremio que sorteia um número que corresponderá ao 
número de inscrição do participante e declara o vencedor.*/

using System;
using System.Random;

class Sorteio
{
    private int numInscritos;
    private Random sorteio = new Random();
    public Sorteio(int numInscritos)
    {
        this.numInscritos = numInscritos;
    }

    public int sorteiaPremio()
    {
        int vencedor = sorteio.Next(1, numInscritos + 1);
        return vencedor;
    }

    Sorteio sorteio = new Sorteio(10); 
    int vencedor = sorteio.sorteiaPremio();
    Console.WriteLine("O vencedor é o participante de número " + vencedor + "!");
}