﻿using System;
 
namespace GeradorDeJogosLoteria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            Double[] ordemCrescente=new double[6];
            Random random = new Random();

            Console.WriteLine("\nBem-vindo ao gerador de jogos da loteria!");

            Console.Write("\nQuantos jogos você deseja gerar? ");
            int quantidadeDeJogos = int.Parse(Console.ReadLine()!);
             
            for (int i = 1; i <= quantidadeDeJogos; i++)
            {
                Console.Write($"\nJogo {i}: ");
                var numerosSorteados=new HashSet<int>();
                
                for (int j = 0; j < 6; j++)
                {
                    ordemCrescente[j]=random.Next(1, 61);
                }
                for(int j = 1;j < 61; j++)
                {
                    for(int k=0;k<6;k++)
                    {
                    if(j==ordemCrescente[k])
                    {
                        Console.Write(j+" ");
                    }
                    }
                }
            }
            Console.WriteLine("\n");
        }
    }

    }

    // Júnior Silva 