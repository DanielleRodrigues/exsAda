using System;

abstract class Smartphone
{
protected string numero;
protected string modelo;
protected string imei;
protected int memoria;

public Smartphone(string numero, string modelo, string imei, int memoria)
{
    this.numero = numero;
    this.modelo = modelo;
    this.imei = imei;
    this.memoria = memoria;
}

public void ligar()
{
    Console.WriteLine("Fazendo uma ligação...");
}

public void receberLigacao()
{
    Console.WriteLine("Recebendo uma chamada...");
}

public abstract void instalarAplicativo(string nome);
}