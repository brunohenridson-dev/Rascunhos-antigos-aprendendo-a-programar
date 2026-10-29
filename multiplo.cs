using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
class Program
{
static void Main(string[] args)
    {   
        int a,
        b;

        Console.WriteLine("escreva um número");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("escreva outro número");
        b = int.Parse(Console.ReadLine());

        if(a % b == 0)
        {
            Console.WriteLine("o primeiro é multiplo do segundo");
        }
        else
        {
            Console.WriteLine("o primeiro não é multiplo do segundo");
        }

    }
}
