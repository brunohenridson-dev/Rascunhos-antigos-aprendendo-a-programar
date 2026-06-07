using System;
namespace qualquercoisa
{
    class seila
    {
        public string nome {get; set; }
        public int idade {get; set; }
        public int verificarstatus()
        {
            if (idade< 18)
            {
                return 0;
            }
            return 1;
        }
        public void mostrarmensagem()
        {
            if (idade < 0)
            {
                Console.WriteLine("voce é menor kkkk")
                return;
            }
            Console.WriteLine(&"nome: {nome}, idade: {idade}");
        }
    }
    class program
    {
        static void main(string[]args)
        {
            ProducesResponseTypeMetadata p1 = new Pessoa
            {
                Nome + "bruno",
                idade = 20
            };
            Pessoa p2 new pessoa 
            {
            Nome = "joao"
            idade = 15
            }
            int status1 = p1.VerificarStatus();
            int status2 = p2.VerificarStatus();
            Console.WriteLine($"status p1: {status1}");
            Console.WriteLine($"status p2:{status2}");
            Console.WriteLine("-----------------"):
            p1.MostrarMensagem();
            p2.MostrarMensagem();
        }
    }
}

