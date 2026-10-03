using System;
using System.Runtime.InteropServices;

class Program{
static void Main(string[] args)
{
    // Seu código entra aqui
            string []sobrenomes = ["bruno","luisa","carol"];
            nomes(sobrenomes);
}
    static void nomes(params string[] notas)
    {
        foreach(string nota in notas)
        {
            Console.WriteLine(nota);
        }

    }
}
