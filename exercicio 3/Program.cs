using System;

namespace exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá , qual o valor de seu salario ?");
            double valor = double.Parse(Console.ReadLine());
            
             if(valor <= 500) {
                Console.WriteLine("voce ganhou um aumento" + valor * 0,3);
             }
            else  {
                Console.WriteLine("voce não tem direito a aumento");
            }   
        }
    }
}
