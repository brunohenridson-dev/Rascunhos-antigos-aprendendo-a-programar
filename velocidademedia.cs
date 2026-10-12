using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Dynamic;
using System.Diagnostics;



class Program
{
static void Main(string[] args)
    {
        int velocidade, tempo, destino;

    Console.Write("qual a sua velocidade?");
    velocidade = int.Parse(Console.ReadLine());
    Console.Write("qual o seu tempo?");
     tempo = int.Parse(Console.ReadLine());
     Console.Write("qual a distancia de destino?");
     destino = int.Parse(Console.ReadLine());

     int resultadoFinal = DestinoFinal(velocidade,tempo,destino);

     Console.WriteLine("essa é a velocidade média "+ resultadoFinal);
    }
    static int DestinoFinal(int destino,int tempo,int velocidade)
    {
       int velocidadeMedia = destino / tempo;
       return velocidadeMedia;
    }
}
