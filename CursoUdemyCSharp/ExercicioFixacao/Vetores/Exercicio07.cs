using System;

namespace Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double media;
            string aprovados;

            n = int.Parse(Console.ReadLine());

            string[] nomes = new string[n];
            double[] primeiroSemestre = new double[n];
            double[] segundoSemestre = new double[n];


            for (int i = 0; i < n; i++)
            {
                string[] v = Console.ReadLine().Split(' ');
                nomes[i] = v[0];
                primeiroSemestre[i] = double.Parse(v[1]);
                segundoSemestre[i] = double.Parse(v[2]);
            }

            Console.WriteLine("Alunos Aprovados: ");

            for (int i = 0; i < n; i++)
            {
                media = (primeiroSemestre[i] + segundoSemestre[i]) / 2;
                if (media >= 6.0)
                {
                    aprovados = nomes[i];
                    Console.WriteLine(aprovados);
                }
            }
        }
    }
}