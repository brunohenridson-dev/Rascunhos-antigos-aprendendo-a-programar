using System;
using System.IO.Compression;
using Microsoft.VisualBasic;

public class Time
{
static void Main()
    {
        string x,
        y;

        int z = 1;
        do{
        Console.Write("digite um nome");
        x = Console.ReadLine();
        Console.WriteLine("digite um email");
        y = Console.ReadLine();
        try{
        Console.WriteLine("digite sua idade");
        z = int.Parse(Console.ReadLine());

        Console.WriteLine("escreva zero se você quer sair");

        if(z < 0)
            {
                Console.WriteLine("sua idade deve ser positiva");
            }
            else if(z > 110)
            {
                Console.WriteLine("sua idade é grande demais");
            }
        }
        catch(Exception error)
        {
            Console.WriteLine("escreva um número");
        }
        

        Usuario usuario = new Usuario(x,y,z);
        usuario.ExibirInfo();
        } while(x != "0" || y != "0" || z != 0);
    }
}

public class Usuario
{
    public string Nome {get;set;}
    public string Email {get; set;}
    public int Idade {get; set;}

    public Usuario(string nome,string email,int idade)
    {
        this.Nome = nome;
        this.Email = email;
        this.Idade = idade;
    }
    public void ExibirInfo()
    {
        Console.Write($"Nome: {this.Nome}, E-mail:{this.Email}, Idade: {this.Idade}");
    }
    
}
