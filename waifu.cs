using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Reflection.PortableExecutable;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("quem é a sua waifu?");
        string waifusinha = Console.ReadLine();
        waifu.ListaWaifu(waifusinha);
    }
    class waifu
    {
        public static void ListaWaifu(string waifusinhaInicial){
            List<string> wife = new list<string>();
            wife.Add(waifusinhaInicial);
            Console.WriteLine("voce quer continuar a adicionar waifu?(sim/não)");
            string qualquer = Console.ReadLine().ToLower();

                    while(qualquer == sim){
                        Console.WriteLine("digite o nome de mais uma waifu");
                        string proximaWaifu = Console.ReadLine();
                        wife.Add(proximaWaifu);
                        Console.WriteLine("você quer continuar a adicionar waifu? (sim/nao)");
    qualquer = Console.ReadLine().ToLower();
        }
        Console.WriteLine("\nsua lista waifu chegou ao fim:");
        foreach(var item in wife)
            {
               Console.WriteLine("sua waifu: " + item); 
            }
        }

    }
}
