using System;

namespace Semáforo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a cor do semáforo (verde,vermelho,amarelo):");
            string cordosem = (Console.ReadLine());

            if(cordosem == "vermelho") {
                Console.WriteLine("Pare!");
                    }
            if(cordosem == "amarelo") {
                Console.WriteLine("Reduza e Pare!");
                    }
            else {
                Console.WriteLine("Siga !");
                    }   
            
        }
    }
}
