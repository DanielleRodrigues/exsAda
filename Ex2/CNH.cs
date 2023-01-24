/* Construa uma classe CNH que tenha como propriedades país e idade que, 
por padrão, deve ser maior ou igual a 18,

 16 se país for igual a US ou CA e
 21 se páis corresponder a CH ou RU.

 Se o país for BR deve também ser informada a
 categoria da carteira (A, B, C, D, E, AB, AC, AD ou AE).*/

 public class CNH
{
    public string Pais { get; set; }
    public int Idade { get; set; }
    public string Categoria { get; set; }

    public CNH(string pais, int idade, string categoria = null)
    {
        Pais = pais;
        if (pais == "BR")
        {
            if (idade < 18)
                Console.WriteLine("Idade deve ser maior ou igual a 18 para o país BR.");

            if (!string.IsNullOrEmpty(categoria) && !categoria.All(c => "ABCDE".Contains(c)))
                Console.WriteLine("Categoria inválida para o país BR. Valores válidos: A, B, C, D, E, AB, AC, AD ou AE.");

            Categoria = categoria;
        }
        else if (pais == "US" || pais == "CA")
        {
            if (idade < 16)
                Console.WriteLine("Idade deve ser maior ou igual a 16 para os países US e CA.");
        }
        else if (pais == "CH" || pais == "RU")
        {
            if (idade < 21)
                Console.WriteLine("Idade deve ser maior ou igual a 21 para os países CH e RU.");
        }
        else
        {
            if (idade < 18)
                Console.WriteLine("Idade deve ser maior ou igual a 18 para os outros países.");
        }
        Idade = idade;
    }

    CNH cnh = new CNH("BR", 24, "B");
}