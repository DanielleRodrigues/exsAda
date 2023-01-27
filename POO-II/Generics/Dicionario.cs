class Dicionario
{
    List<Termo> termos = new List<Termo>();

    public void AdicionarTermo(string palavra, string definicao)
    {
        Termo novoTermo = new Termo();
        novoTermo.palavra = palavra;
        novoTermo.definicao = definicao;
        termos.Add(novoTermo);
    }

    public List<Termo> BuscarTermo(string busca)
    {
        List<Termo> resultados = new List<Termo>();
        busca = busca.ToLower();

        foreach (Termo termo in termos)
        {
            if (termo.palavra.ToLower().Contains(busca))
            {
                resultados.Add(termo);
            }
        }

        if (resultados.Count == 0)
        {
            Console.WriteLine("Nenhum termo encontrado");
        }

        return resultados;
    }

    public void SalvarDicionario()
    {
        using (StreamWriter escritor = new StreamWriter("dicionario.txt"))
        {
            foreach (Termo termo in termos)
            {
                escritor.WriteLine(termo.palavra + "|" + termo.definicao);
            }
        }
    }

    public void CarregarDicionario()
    {
        if (File.Exists("dicionario.txt"))
        {
            using (StreamReader leitor = new StreamReader("dicionario.txt"))
            {
                string linha;
                while ((linha = leitor.ReadLine()) != null)
                {
                    string[] partes = linha.Split('|');
                    AdicionarTermo(partes[0], partes[1]);
                }
            }
        }
    }
}