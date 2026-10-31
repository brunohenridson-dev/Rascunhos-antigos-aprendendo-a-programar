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
        int total,
        gradecounter,
        gradeValue,
        avarage;

        total = 0;
        gradecounter = 1;

        while(gradecounter <= 10)
                {       
                        gradeValue = 0;

                        try{
                        Console.WriteLine("enter integer grade ");
                         gradeValue = Int32.Parse(Console.ReadLine());
                         }
                        catch(FormatException erro)
                        {
                                Console.WriteLine("você não digitou um número válido");
                        }

                        total += gradeValue;
                        gradecounter ++;

                }
                avarage = total / 10;

                Console.WriteLine("\nClass avarage is {0}",avarage);
        }

}
