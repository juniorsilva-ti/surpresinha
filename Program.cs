using System;
 
namespace GeradorDeJogosLoteria
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
 Console.WriteLine();
            Console.WriteLine("Bem-vindo ao gerador de jogos da loteria!");
 Console.WriteLine();
            Console.Write("Quantos jogos você deseja gerar (até 10)? ");
            int quantidadeDeJogos = int.Parse(Console.ReadLine()!);
 
            if (quantidadeDeJogos > 10)
            {
                Console.WriteLine();
                Console.WriteLine("Desculpe, só é possível gerar até 10 jogos.");
                Console.WriteLine();
                return;
                
            }
 
            for (int i = 1; i <= quantidadeDeJogos; i++)
            {
                Console.Write($"\nJogo {i}: ");
                for (int j = 1; j <= 6; j++)
                {
                    Console.Write($"{random.Next(1, 61)} ");
                }
            }
        }
    }
}