class Program
{
    static void Main(string[] args)
    {
        Leao leao = new Leao();
        leao.Nome = "Simba";
        leao.DatadeNascimento = new DateTime(2010, 1, 1);
        leao.Sexo = 'M';
        leao.Idade = 13;
        leao.Carnivoro = true;
        leao.Peconhento = false;
        leao.CaudaComBarbas = true;
        
        Console.WriteLine("Nome do Leão: " + leao.Nome);
        Console.WriteLine("Data de Nascimento: " + leao.DatadeNascimento);
        Console.WriteLine("Sexo: " + leao.Sexo);
        Console.WriteLine("Idade: " + leao.Idade);
        Console.WriteLine("Carnivoro: " + leao.Carnivoro);
        Console.WriteLine("Peçonhento: " + leao.Peconhento);
        Console.WriteLine("Cauda com barbas: " + leao.CaudaComBarbas);
        leao.Rugir();
        leao.Movimentar();
        leao.Comunicar();
        leao.Alimentar();
        leao.Amamentar();

        Morcego morcego = new Morcego();
        morcego.Nome = "Dracula";
        morcego.DatadeNascimento = new DateTime(2011, 1, 1);
        morcego.Sexo = 'M';
        morcego.Idade = 12;
        morcego.Carnivoro = true;
        morcego.Peconhento = false;
        morcego.AltitudeMaximaEmMetros = 1000;
        morcego.VelocidadeDoVoo = 20;
        
        Console.WriteLine("\nNome do Morcego: " + morcego.Nome);
        Console.WriteLine("Data de Nascimento: " + morcego.DatadeNascimento);
        Console.WriteLine("Sexo: " + morcego.Sexo);
        Console.WriteLine("Idade: " + morcego.Idade);
        Console.WriteLine("Carnivoro: " + morcego.Carnivoro);
        Console.WriteLine("Peçonhento: " + morcego.Peconhento);
        Console.WriteLine("Altitude Máxima: " + morcego.AltitudeMaximaEmMetros);
        Console.WriteLine("Velocidade do Voo: " + morcego.VelocidadeDoVoo);
        morcego.Voar();
        morcego.Movimentar();
        morcego.Comunicar();
        morcego.Alimentar();
        morcego.Amamentar();

        Cisne cisne = new Cisne();
        cisne.Nome = "Annie";
        cisne.DatdeNascimento = new DateTime(2015, 1, 1);
        cisne.Sexo = 'F';
        cisne.Idade = 8;
        cisne.Carnivoro = false;
        cisne.Peconhento = false;
        cisne.CorPena = "branca";
        cisne.AltitudeMaximaEmMetros = 500;
        cisne.VelocidadeDoVoo = 40;

        Console.WriteLine("\nNome do Cisne: " + cisne.Nome);
        Console.WriteLine("Data de Nascimento: " + cisne.DatadeNascimento);
        Console.WriteLine("Sexo: " + cisne.Sexo);
        Console.WriteLine("Idade: " + cisne.Idade);
        Console.WriteLine("Carnivoro: " + cisne.Carnivoro);
        Console.WriteLine("Peçonhento: " + cisne.Peconhento);
        Console.WriteLine("Cor das penas: " + cisne.CorPena);
        Console.WriteLine("Altitude Máxima: " + cisne.AltitudeMaximaEmMetros);
        Console.WriteLine("Velocidade do Voo: " + cisne.VelocidadeDoVoo);
        cisne.Voar();
        cisne.Ciscar();
        cisne.Movimentar();
        cisne.Comunicar();
        cisne.Alimentar();
        cisne.Botar();
        cisne.Chocar();


        Lontra lontra = new Lontra();
        lontra.Nome = "Lola";
        lontra.DatadeNascimento = new DateTime(2012, 1, 1);
        lontra.Sexo = 'F';
        lontra.Idade = 11;
        lontra.Carnivoro = true;
        lontra.Peconhento = false;
        lontra.ViveEmTerra = false;
        lontra.Mergulho = true;
        lontra.AguaDoce = false;
        
        Console.WriteLine("\nNome da Lontra: " + lontra.Nome);
        Console.WriteLine("Data de Nascimento: " + lontra.DatadeNascimento);
        Console.WriteLine("Sexo: " + lontra.Sexo);
        Console.WriteLine("Idade: " + lontra.Idade);
        Console.WriteLine("Carnivoro: " + lontra.Carnivoro);
        Console.WriteLine("Peçonhento: " + lontra.Peconhento);
        Console.WriteLine("Vive em terra: " + lontra.ViveEmTerra);
        Console.WriteLine("Mergulho: " + lontra.Mergulho);
        Console.WriteLine("Agua doce: " + lontra.AguaDoce);
        lontra.Movimentar();
        lontra.Comunicar();
        lontra.Alimentar();

    }
}