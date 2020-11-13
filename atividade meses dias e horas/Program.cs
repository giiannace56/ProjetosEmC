using System;

namespace atividade_meses_dias_e_horas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("qual sua idade ");
            int idade = int.Parse(Console.ReadLine());

                Console.WriteLine("idade em meses:" + idade * 12 );

                Console.WriteLine("idade em dias:" + idade * 365);

                Console.WriteLine("idade em horas:" + idade * 8760);

                Console.WriteLine("idade em minutos:" + idade * 5256000);
            
            
        }
    }
}
