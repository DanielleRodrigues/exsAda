/*Faça uma classe Album (de figurinhas) que tem como propriedades 
a quantidade de figurinhas e um array de figurinhasColadas que recebe 
os números das figurinhas coladas. Garanta que o array de figurinhasColadas 
apenas pode crescer. Tenha também um método colarFigurinha que permita colar 
figurinhas que existam no álbum e que não foram coladas ainda.*/


using System;
class Album
{
    private int _quantidadeFigurinhas;
    private List<int> _figurinhasColadas;

    public Album(int quantidadeFigurinhas)
    {
        _quantidadeFigurinhas = quantidadeFigurinhas;
        _figurinhasColadas = new List<int>();
    }

    public void ColarFigurinha(int numeroFigurinha)
    {
        if (numeroFigurinha > _quantidadeFigurinhas || _figurinhasColadas.Contains(numeroFigurinha))
        {
            Console.WriteLine("Figurinha inválida ou já colada.");
        }
        else
        {
            _figurinhasColadas.Add(numeroFigurinha);
        }
    }
    // Album meuAlbum = new Album(100);
    // meuAlbum.ColarFigurinha(5);
}