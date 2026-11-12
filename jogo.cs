using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

using System;

class Program
{
    static void Main()
    {
        EstadoJogador estado = EstadoJogador.pulando;

        if(estado == EstadoJogador.pulando)
        {
            Console.WriteLine("aumentar a velocidade");
        }
    }

}
enum EstadoJogador : byte
{
    parado,
    andando,
    correndo,
    pulando,
    atacando,
    morto
}
