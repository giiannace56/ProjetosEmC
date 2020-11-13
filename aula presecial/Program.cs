using System;

namespace aula_presecial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Bem vindo a seletiva para o time de counter-strike");
            Console.WriteLine ("--------------------------------------------------");
            Console.WriteLine ("Gostaria de participar ? Sim ou Não");
            string resposta = Console.ReadLine();

            if (resposta == "Sim" ){
                Console.WriteLine("Vamos seguir então , conte mais sobre você !");
            
                Console.WriteLine("Me diga suas notas : ");
                int media = int.Parse(Console.ReadLine());
                Console.WriteLine("quantas faltas você tem ?");
                int faltas = int.Parse(Console.ReadLine());
                if(media >= 50 && faltas <= 10) {
                    Console.WriteLine ("Seja bem vindo ao time !");
                }
                else {
                    Console.WriteLine ("busque melhorar suas faltas e notas");
                }
            }

            else {
                Console.WriteLine("Obrigado pela atenção !");
            }

        }
    }
}
