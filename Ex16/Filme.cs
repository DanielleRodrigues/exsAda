class Filme : Programa
{
    public int Duracao { get; set; }

    public Filme(int duracao, List<string> generos) : base(duracao, generos)
    {
        Duracao = duracao;
    }
}