using System;

class Program
{
    public struct Ponto
    {
        public int X { get; set; }

        public Ponto(int x)
        {
            X = x;
        }
    }

    static void Main(string[] args)
    {
        int baseNum, expoente, z;

        Console.WriteLine("qual o número base?");
        baseNum = int.Parse(Console.ReadLine());

        Ponto a = new Ponto(baseNum);

        Console.WriteLine("qual o número que voce quer exponenciar?");
        expoente = int.Parse(Console.ReadLine());

        for (z = 1; z < expoente; z++)
        {
            a.X = a.X * baseNum; 
        }

        Console.WriteLine($"Resultado: {a.X}");
    }
}
