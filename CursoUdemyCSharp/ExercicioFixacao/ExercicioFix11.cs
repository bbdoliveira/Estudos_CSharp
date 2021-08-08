using System;
using System.Globalization;

namespace ExercicioFix11

{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double[] vet;
            double soma = 0.0, media;

            N = int.Parse(Console.ReadLine());
            vet = new double[N];

            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)//Loop de armazenamento dos valores no vetor
            {
                vet[i] = double.Parse(s[i]);
            }

            for (int i = 0; i < N; i++)//Loop de impressão dos valores
            {
                Console.Write(vet[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < N; i++)//Loop para soma dos valores
            {
                soma += vet[i];
            }
            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));

            media = soma / N;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}