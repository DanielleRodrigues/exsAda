class Seriado : Programa
{
    public int NumeroDeEpisodios { get; set; }
    public int AnoDeInicio { get; set; }
    public int AnoDeFim { get; set; }

    public Seriado(int duracao, List<string> generos, int numeroDeEpisodios, int anoDeInicio, int anoDeFim) : base(duracao, generos)
    {
        NumeroDeEpisodios = numeroDeEpisodios;
        AnoDeInicio = anoDeInicio;
        AnoDeFim = anoDeFim;
    }
}