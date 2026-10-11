using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography.X509Certificates;


class Program
{
static void Main(string[] args)
    {
        Console.WriteLine("escreva qual o seu time:");
        string nomeTime = Console.ReadLine();

        Console.WriteLine("escreva qual o seu time e sua pontuação na 12 rodada");
        string pontuacao = Console.ReadLine();
        int pontos = int.Parse(pontuacao);
        //construtor pra poder enviar pro calcular

       Clube meuClube = new Clube();
       meuClube.nome = nomeTime;
       meuClube.ponto = pontos;

       //voce pega a classe e instancia ela,coloca o nome com o read
       //coloca o ponto com o read
         Calcular(meuClube);
    }
    public static void Calcular(Clube c)
    {   
        Pontosnovo = c.ponto / 12 * 38;
        if(c.ponto < 45)
        {
            Console.Write("a trajetória é que seu clube caia");
        }
        else
        {
            Console.Write("seu time não vai cair");
        }
    }
    public class Clube
    {
        public int ponto;
        public string nome;
    }
}
