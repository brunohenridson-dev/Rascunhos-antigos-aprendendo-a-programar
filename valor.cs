using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
class Program
{
static void Main(string[] args)
        {
                float x,
                y,
                z;

                Console.WriteLine("qual o valor de x");
                x = float.Parse(Console.ReadLine());

                Console.WriteLine("qual o valor de y?");
                y = float.Parse(Console.ReadLine());

                z = x + y;
                Console.WriteLine(z);
                x++;
                Console.WriteLine("esse é o valor de x "+ x);
        }

}
