using System;

namespace projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro numero: ");
            
            int nm1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");

            int nm2 = int.Parse(Console.ReadLine());

            int soma = nm1 + nm2 ;

            Console.WriteLine("RESULTADO= " + soma) ;
        }
    }
}
