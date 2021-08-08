using System;
using System.Globalization;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, indice = 0;
            double maior = 0.0;

            N = int.Parse(Console.ReadLine());

            double[] numeros = new double[N];

            string[] v = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                numeros[i] = double.Parse(v[i]);

                if (numeros[i] > maior )
                {
                    maior = numeros[i];
                    indice = i;
                }
            }

            Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(indice);
        }
    }
}