using System;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, idadeDoVelho = 0;
            string maisVelha = "";

            N = int.Parse(Console.ReadLine());

            string[] nome = new string[N];
            int[] idade = new int[N];

            

            for (int i = 0; i < N; i++)
            {
                String[] vet = Console.ReadLine().Split(' ');
                nome[i] = (vet[0]);
                idade[i] = int.Parse(vet[1]);

                if (idade[i] > idadeDoVelho)
                {
                    idadeDoVelho = idade[i];
                    maisVelha = nome[i];
                }
            }
            Console.WriteLine("Pessoa mais velha: " + maisVelha);
        }
    }
}