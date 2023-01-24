/*Construa uma classe Boletim para uma faculdade com as propriedades: 
nome (do aluno), 
ano (maior que 1964), 
semestre(de 1 a 14) 
e um List com as médias de 6 máterias.*/
public class Boletim
{
    public string Nome { get; set; }
    public int Ano { get; set; }
    public int Semestre { get; set; }
    public List<string> Materias { get; set; }
    public List<double> Medias { get; set; }

    public Boletim(string nome, int ano, int semestre, List<double> medias)
    {
        if (ano < 1964)
            Console.WriteLine("Ano deve ser maior que 1964.");
        if (semestre < 1 || semestre > 14)
            Console.WriteLine("Semestre deve estar entre 1 e 14.");

        Nome = nome;
        Ano = ano;
        Semestre = semestre;
        Medias = medias;
    }
List<string> materias = new List<string>() { "Matemática", "Física", "Química", "Português", "História", "Inglês" };
List<double> medias = new List<double>() { 7.5, 8.0, 9.0, 7.0, 8.5, 9.5 };
Boletim boletim = new Boletim("Fulaninho", 2022, 2, materias, medias);
}

