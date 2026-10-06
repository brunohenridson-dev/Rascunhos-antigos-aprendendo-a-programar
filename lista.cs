using System;
using System.Collections.Generic;

class Program
{
    static List<string> lista = new List<string>();

    static void Main(string[] args)
    {
        Console.WriteLine("Escreva um item para mandar para a lista:");
        string item = Console.ReadLine();

        lista.Add(item);

        Console.WriteLine("Você quer mostrar a lista? (SIM ou NAO)");
        string resposta = Console.ReadLine().ToUpper();

        ExibirLista(resposta);
    }

    static void ExibirLista(string mostrarLista)
    {
    
        if (mostrarLista == "SIM")
        {
            foreach (string item in lista)
            {
                Console.WriteLine($"Item no inventário: {item}");
            }
        }
    }
}
