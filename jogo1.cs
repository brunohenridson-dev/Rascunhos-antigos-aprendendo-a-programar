using System;

class Program
{
    static void Main(string[] args)
    {
        int vidaPlayer = 3;
        int vidaMaquina = 3;
        Random gerador = new Random();

        Console.WriteLine("=== INÍCIO DO JOGO DA MÁQUINA ===");

        // O loop principal roda enquanto AMBOS estiverem vivos!
        while (vidaMaquina > 0 && vidaPlayer > 0)
        {
            Console.WriteLine($"\n--- NOVA RODADA (Sua Vida: {vidaPlayer} | Vida Máquina: {vidaMaquina}) ---");

            // 1. Pede o número e valida (DENTRO do loop do jogo)
            int numero = 0; // Criada fora do 'while' de validação
            while (numero < 1 || numero > 10)
            {
                Console.Write("Digite um número de 1 a 10: ");
                numero = int.Parse(Console.ReadLine()); // Atualiza sem o 'int' na frente!
            }

            // 2. Sorteia o número da máquina a cada rodada
            int numeroAleatorio = gerador.Next(1, 11);

            // 3. Turno da Máquina (Tenta zerar o seu)
            if (numero % numeroAleatorio == 0)
            {
                vidaPlayer -= 1;
                Console.WriteLine($"💥 Você tomou 1 de dano! Número da máquina: {numeroAleatorio}");
            }
            else
            {
                Console.WriteLine($"🛡️ Você não tomou dano! O número da máquina foi: {numeroAleatorio}");
            }

            // 4. Seu Turno (Tenta zerar o da máquina)
            if (numeroAleatorio % numero == 0)
            {
                vidaMaquina -= 1;
                Console.WriteLine($"⚔️ Você causou 1 de dano na máquina! Seu número: {numero} | Máquina: {numeroAleatorio}");
            }
            else
            {
                Console.WriteLine($"🛡️ Você não causou dano na máquina! Seu número: {numero} | Máquina: {numeroAleatorio}");
            }
        }

        // Fim de jogo
        Console.WriteLine("\n===========================");
        if (vidaPlayer <= 0)
        {
            Console.WriteLine("💀 Você perdeu!");
        }
        else if (vidaMaquina <= 0)
        {
            Console.WriteLine("🏆 Você ganhou!");
        }
    }
}
