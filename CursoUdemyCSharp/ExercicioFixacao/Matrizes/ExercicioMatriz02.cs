using System;

namespace ExercicioMatriz02
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[,] A;

            N = int.Parse(Console.ReadLine());
            A = new int[N, N];

            for (int i = 0; i < N; i++)//Peenche a Matriz
            {
                string[] v = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = int.Parse(v[j]);
                }
            }

            Console.WriteLine("DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(A[i, i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (A[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("QUANTIDADE DE NEGATIVOS = " + count);
        }
    }
}