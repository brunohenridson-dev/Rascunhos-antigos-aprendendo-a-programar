using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
class Program
{
static void Main(string[] args)
    {
        int a,
        b,
        c,
        d,
        e,
        r;

        bool flamengo = true;
        while(flamengo)
        {

        Console.WriteLine("qual o número que voce quer calcular?");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("qual outro número que voce quer calcular?");
        b = int.Parse(Console.ReadLine());

        c = a + b;
        d = a - b;
        e = a * b;
        r = a / b;

        Console.WriteLine("essa é a sua soma "+ c);
        Console.WriteLine("essa é a sua diminuição "+ d);
        Console.WriteLine("essa é a sua multiplicação "+ e);
        Console.WriteLine("essa é a sua divisão "+ r);

        Console.WriteLine("voce quer continuar s/n?");
        string sim = Console.ReadLine();

        if(sim == "n")
            {
                flamengo = false;
                return ;
            }
        }

       
    }
}
