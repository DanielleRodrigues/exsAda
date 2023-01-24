/*Crie uma classe Carro que tenha as propriedades: 
cor, marca, modelo (sedan ou hatch), capacidadeDoTanque (em litros), 
tipoDeCombustível (gasolina, álcool ou flex) 
e um método abastecer que respeite o tipo de 
combustível que o automóvel aceita e a capacidade máxima de litros.*/
using System;
class Carro
{
    private readonly double precoGasolina = 5.62;
    private readonly double precoEtanol = 4.16;

    public string Cor { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public double CapacidadeDoTanque { get; set; }
    public string TipoDeCombustivel { get; set; }

    public void Abastecer(double litros, string tipoDeCombustivel)
    {
        if (TipoDeCombustivel != tipoDeCombustivel)
        {
            Console.WriteLine("Esse veículo não aceita esse tipo de combustível.");
            return;
        }

        if (litros > CapacidadeDoTanque)
        {
            Console.WriteLine("A capacidade máxima do tanque é de " + CapacidadeDoTanque + " litros.");
            return;
        }

        double preco = 0;
        if (tipoDeCombustivel == "Gasolina")
        {
            preco = precoGasolina * litros;
        }
        else if (tipoDeCombustivel == "Etanol")
        {
            preco = precoEtanol * litros;
        }

        Console.WriteLine("Abastecimento realizado com sucesso! Valor total: R$ " + preco);

        Carro meuCarro = new Carro();

        meuCarro.Cor = "Preto Fosco";
        meuCarro.Marca = "Honda";
        meuCarro.Modelo = "Sedan";
        meuCarro.CapacidadeDoTanque = 50;
        meuCarro.TipoDeCombustivel = "Flex";

        meuCarro.Abastecer(40, "Etanol");
    }

}