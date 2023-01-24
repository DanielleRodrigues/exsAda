/*Faça uma classe Perfil que tem as seguintes informações: nome, avatar (foto de perfil) e tema. 
Utilize acessors (get/set) para garantir que o tema só pode ser "light" ou "dark" 
e que a foto de perfil deve ser uma url (iniciada com http ou https).*/
using System;
class Perfil
{
    private string _nome;
    private string _avatar;
    private string _tema;

    public Perfil(string nome, string avatar, string tema)
    {
        Nome = nome;
        Avatar = avatar;
        Tema = tema;
    }

    public string Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }

    public string Avatar
    {
        get { return _avatar; }
        set
        {
            if (!value.StartsWith("http") && !value.StartsWith("https"))
                Console.WriteLine("A URL da foto de perfil deve começar com http ou https");
            _avatar = value;
        }
    }

    public string Tema
    {
        get { return _tema; }
        set
        {
            if (value != "light" && value != "dark")
                Console.WriteLine("O tema deve ser light ou dark");
            _tema = value;
        }
    }

    /*Perfil perfil = new Perfil("Danielle Rodrigues", "https://photos.com/foto_perfil.jpg", "dark");
    Console.WriteLine("Nome: " + perfil.Nome);
    Console.WriteLine("Avatar: " + perfil.Avatar);
    Console.WriteLine("Tema: " + perfil.Tema);
    
    Eu particularmente não conhecia o método "StartsWith" achei legal.*/
    }
