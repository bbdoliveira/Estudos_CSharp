using System;
using System.Globalization;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            int nCasos, peso = 10;
            double nota1, nota2, nota3, media;

            nCasos = int.Parse(Console.ReadLine());



            for (int i = 1; i <= nCasos; i++)
            {
                string[] v = Console.ReadLine().Split(' ');
                nota1 = (double.Parse(v[0]) * 2);
                nota2 = (double.Parse(v[1]) * 3);
                nota3 = (double.Parse(v[2]) * 5);

                media = (nota1 + nota2 + nota3) / peso;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }

        }
    }
}
