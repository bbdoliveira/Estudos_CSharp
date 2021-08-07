using System;
using System.Globalization;

namespace ExercicioFix07
{
    class Program
    {
        static void Main(string[] args)
        {
            double media, idade, soma;
            int count;

            idade = double.Parse(Console.ReadLine());
            soma = 0.0;
            count = 0;

            if (idade < 0.0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                while (idade >= 0)
                {
                    soma += idade;
                    count++;
                    idade = double.Parse(Console.ReadLine());
                }
                media = soma / count;
                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            }


        }
    }
}