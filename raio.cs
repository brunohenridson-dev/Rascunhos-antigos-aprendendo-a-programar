using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
class Program
{
static void Main(string[] args)
    {   
        int a;
        double pi = 3.1415926535;

        Console.WriteLine("qual o raio do círculo?");
        a = int.Parse(Console.ReadLine());

        double diameter = a*2;
        double circunferencia = pi*2*a;
        double area = pi*a*a;

        Console.WriteLine("esse é o diametro "+ diameter);
        Console.WriteLine("esse é a cirscunferencia " + circunferencia);
        Console.WriteLine("essa é a area " + area);

    }
}
