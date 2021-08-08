using System;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[] A, B, C;

            N = int.Parse(Console.ReadLine());

            A = new int[N];
            B = new int[N];
            C = new int[N];

            string[] v = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(v[i]);
            }

            string[] v2 = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                B[i] = int.Parse(v2[i]);
            }

            for (int i = 0; i < N; i++)
            {
                C[i] = A[i] + B[i];
                Console.Write(C[i] + " ");
            }
        }
    }
}