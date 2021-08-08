using System;
using System.Globalization;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double soma = 0.0, media = 0.0;
            double[] vetReal;

            N = int.Parse(Console.ReadLine());

            vetReal = new double[N];

            string[] v = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                vetReal[i] = double.Parse(v[i]);
                soma += vetReal[i];
            }

            media = (double) soma / N;
            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));

            for (int i = 0; i < N; i++)
            {
                if (vetReal[i] < media)
                {
                    Console.WriteLine(vetReal[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}