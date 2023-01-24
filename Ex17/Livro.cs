/*Crie uma classe Livro com as propriedades autor e ano. Crie também as classes Ebook e AudioBook que herdam de Livro. Ebook deve ter numero de páginas e número de capítulos. Já a classe AudioBook deve ter a duração total do áudio em minutos.
*/

using System;
class Livro
{
    public string Autor { get; set; }
    public int Ano { get; set; }


    Livro livro = new Livro()
    {
        Autor = "Chuck Palahniuk",
        Ano = 1996
    };

    Ebook ebook = new Ebook()
    {
        Autor = "Arnold Bennett",
        Ano = 1908,
        NumeroDePaginas = 87,
        NumeroDeCapitulos = 7
    };

    AudioBook audiobook = new AudioBook()
    {
        Autor = "Aluísio Azevedo",
        Ano = 1890,
        DuracaoTotalEmMinutos = 549.6
    };

}

