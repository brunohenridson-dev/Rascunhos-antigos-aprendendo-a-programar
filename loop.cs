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
        int passes = 0,
        failures = 0,
        student = 1,
        result;

        result = 0;

        while(student <= 10)
                {
                        try{
                        Console.Write("enter result(1 = pass, 2= fail)");
                        result = Int32.Parse(Console.ReadLine());
                        }
                        catch(Exception error)
                        {
                                Console.WriteLine("write something valid");
                              
                        }

                        if(result == 1)
                        {
                                passes = passes +1;
                        }
                        else
                        {
                                failures ++;
                                student ++;
                        }
                        Console.WriteLine();
                        Console.WriteLine("passed:" + passes);
                        Console.WriteLine("failed:" + failures);

                        if(passes > 8)
                        {
                                Console.WriteLine("raise tuition\n");
                        }
                
                }
        }

}
