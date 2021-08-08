using System;
using System.Globalization;

namespace ExercicioFix12

{
    class Program
    {
        static void Main(string[] args)
        {
            int N, cont = 0;
            double soma = 0, media, menores;
            string[] nome;
            int[] idade;
            double[] altura;

            N = int.Parse(Console.ReadLine());
            nome = new string[N];
            idade = new int[N];
            altura = new double[N];


            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nome[i] = s[0];
                idade[i] = int.Parse(s[1]);
                altura[i] = double.Parse(s[2]);

                if (idade[i] < 16)
                {
                    cont++;
                }
            }

            menores = (double) cont / N * 100.0;

            for (int i = 0; i < N; i++)
            {
                soma += altura[i];
            }

            media = soma / N;

            Console.WriteLine("Altura média: " + media.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Pessoa com menos de 16 anos: " + menores.ToString("F1", CultureInfo.InvariantCulture) + "%");
        }
    }
}