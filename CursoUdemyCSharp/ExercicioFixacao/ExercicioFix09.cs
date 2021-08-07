using System;
using System.Globalization;

namespace ExercicioFix09
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double[] vet;

            N = int.Parse(Console.ReadLine());
            vet = new double[N];

            for (int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}