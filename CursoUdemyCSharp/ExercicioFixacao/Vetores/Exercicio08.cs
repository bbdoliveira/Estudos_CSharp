using System;
using System.Globalization;

namespace Exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, count = 0, homens = 0;
            double soma = 0.0, maior = 0.0, menor = 0.0, media;

            N = int.Parse(Console.ReadLine());

            double[] altura = new double[N];
            char[] sexo = new char[N];

            for (int i = 0; i < N; i++)
            {
                string[] v = Console.ReadLine().Split(' ');
                altura[i] = double.Parse(v[0]);
                sexo[i] = char.Parse(v[1]);
            }

            //Verifica a altura maior e menor.
            for (int i = 0; i < N; i++)
            {
                if (altura[i] > maior)
                {
                    menor = maior;
                    maior = altura[i];
                }
                else
                {
                    if (altura[i] < menor)
                    {
                        menor = altura[i];
                    }
                }
            }

            //Verifica o sexo para fazer media e contagem de homens.
            for (int i = 0; i < N; i++)
            {
                if (sexo[i] == 'F')
                {
                    soma += altura[i];
                    count ++;
                }
                else if (sexo[i] == 'M')
                {
                    homens++;
                }
            }
            media = (double) soma / count;
            Console.WriteLine("Menor altura = " + menor.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Maior altura - " + maior.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Media das alturas das mulheres = " + media.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Numero de homens = " + homens);
        }
    }
}