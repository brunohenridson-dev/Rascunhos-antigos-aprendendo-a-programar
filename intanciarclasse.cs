using System;
using System.Security.Cryptography.X509Certificates;

public class Flamengo
{
    static void Main()
    {   
        int x = 0;
        do{
        
        try{
        Console.WriteLine("escreva algo para instanciar,escreva 0 para sair");
        x = int.Parse(Console.ReadLine());

        lista minhaLista = new lista();
        minhaLista.algum(x);
        }
        catch(Exception error)
        {
            Console.Write("escreva algo válido");
        }

        }while(x != 0);
        
        
    }

}
public class lista
{
    public int y;
    public void algum(int z)
    {
        z *=2;
        Console.WriteLine(z);
    }
}
