/*Construa uma classe Veiculo que tem como propriedades rodas (1 a n), 
usaCombustivel (true/false), 
uma classe Carro (tipoDecombustivel: 'gasolina', 'álcool', 'flex') 
que herda de Veiculo e Bicicleta (infantil: true/false - tem que ter mais que 2 rodas) que também herda as características de Veiculo.*/

using System;
class Veiculo
{
    public int Rodas { get; set; }
    public bool UsaCombustivel { get; set; }

/*Carro meuCarro = new Carro();
meuCarro.Rodas = 4;
meuCarro.UsaCombustivel = true;
meuCarro.TipoCombustivel = "gasolina";

Bicicleta minhaBicicleta = new Bicicleta(false, 3);
minhaBicicleta.UsaCombustivel = false;

Console.WriteLine("O carro possui " + meuCarro.Rodas + " rodas e usa " + meuCarro.TipoCombustivel);
Console.WriteLine("A bicicleta possui" + minhaBicicleta.Rodas + " rodas e " + (minhaBicicleta.UsaCombustivel ? "usa" : "não usa") + " combustível");*/
}