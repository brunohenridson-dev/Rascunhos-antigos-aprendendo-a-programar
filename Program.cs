using System;
namespace arrays
{
    public class fazendoArrays
    {
        static void main(string[]args)
        {
            int[]calculandosete = new int[7];
            for(int i = 0; i < 7; i++)
            {
        
                Console.WriteLine("escolha um numero para somar");
                string Entrada = Console.ReadLine()
                if (int.TryParse(Entrada,out int numero))
                {
                    calculandosete[i] = numero;
                }
                else
                {
                    Console.WriteLine("entrada invalida");
                    calculandosete[i] = 0;
                }

                        
                
            int soma = 0;
            for(int i = 0; i < 7; i++)
            {
                soma += calculandosete[i]
            }
            Console.WriteLine("esse foi o resultado da sua soma;" + soma);
        }
    }
}

