using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, count = 0, pares = 0;

            N = int.Parse(Console.ReadLine());

            int[] numeros = new int[N];

            string[] v = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                numeros[i] = int.Parse(v[i]);

                if (numeros[i] % 2 == 0)
                {
                    pares = numeros[i];
                    Console.Write(pares + " ");
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(count);
        }
    }
}