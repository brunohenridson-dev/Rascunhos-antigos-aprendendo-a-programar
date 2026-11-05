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
        
                int x = 0;
                do{
        try{
                Console.WriteLine("escreva um número,diga 1000 para sair do looping");
                x = int.Parse(Console.ReadLine());

                if(x > 10 && x < 100)
                {
                        Console.WriteLine("x é maior que 10 e menor que 100");
                }
                else if(x < 10)
                {
                        Console.WriteLine("x é menor que 10");
                }
                else
                {
                        Console.WriteLine("x é maior que 100");
                }
        }
                catch(Exception error)
                {
                        Console.WriteLine("escreva algo válido");
                }

                 } while(x < 1000);
        }

       

}
