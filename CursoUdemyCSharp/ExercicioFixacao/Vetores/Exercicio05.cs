using System;
using System.Globalization;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, soma = 0, count = 0;
            double media = 0.0;

            N = int.Parse(Console.ReadLine());

            int[] numerosInt = new int[N];

            string[] v = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                numerosInt[i] = int.Parse(v[i]);

                if (numerosInt[i] % 2 == 0)
                {
                    soma += numerosInt[i];
                    count++;
                }
            }

            media = (double) soma / count;
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}