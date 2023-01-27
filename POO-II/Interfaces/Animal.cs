abstract class Animal
{
    public string Nome { get; set; }
    public DateTime DataDeNascimento { get; set; }
    public char Sexo { get; set; }
    public int Idade { get; set; }
    public bool Carnivoro { get; set; }
    public bool Peconhento { get; set; }
    public void Movimentar();
    public void Comunicar(); 
    public void Alimentar();
}