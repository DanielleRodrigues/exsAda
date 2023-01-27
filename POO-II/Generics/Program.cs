using System;
using System.Collections.Generic;
using System.IO;

class Programa
{
    static void Main(string[] args)
    {
        Dicionario dicionario = new Dicionario();
        dicionario.CarregarDicionario();

        Console.WriteLine("Adicionar termo (A) ou buscar termo (B)?");
        string opcao = Console.ReadLine();

        if (opcao.ToUpper() == "A")
        {
            Console.WriteLine("Digite a palavra:");
            string palavra = Console.ReadLine();
            Console.WriteLine("Digite a definicao:");
            string definicao = Console.ReadLine();
            dicionario.AdicionarTermo(palavra, definicao);
            dicionario.SalvarDicionario();
        }
        else if (opcao.ToUpper() == "B")
        {
            Console.WriteLine("Digite a palavra para buscar:");
            string busca = Console.ReadLine();
            List<Termo> resultados = dicionario.BuscarTermo(busca);
            if (resultados.Count > 0)
            {
                foreach (Termo termo in resultados)
                {
                    Console.WriteLine(termo.palavra + ": " + termo.definicao);
                }
            }
        }
        else
        {
            Console.WriteLine("Opcao invalida");
        }

        Console.ReadLine();
    }
}
