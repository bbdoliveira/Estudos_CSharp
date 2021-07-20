using System;
using System.Globalization;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, 
                count = 0;
            double media, soma = 0.0;

            idade = int.Parse(Console.ReadLine());

            while (idade >= 0)
            {
                soma += idade;
                count++;
                idade = int.Parse(Console.ReadLine());
            }
            media = soma / count;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
