using System;

namespace exercicio_idade_em_ano
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("qual a sua data de nascença");
            int ano = int.Parse(Console.ReadLine());
                int idadeatt = (2020 - ano);
                Console.WriteLine("idade atual:" + idadeatt );

                Console.WriteLine("tempo em semanas:" + idadeatt * 52 );
        }
    }
}
