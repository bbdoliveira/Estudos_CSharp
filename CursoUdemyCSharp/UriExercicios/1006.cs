using System;
using System.Globalization;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, media;
            double pesos = 10;

            a = (double.Parse(Console.ReadLine()) * 2);
            b = (double.Parse(Console.ReadLine()) * 3);
            c = (double.Parse(Console.ReadLine()) * 5);
            media = (a + b + c) / pesos;
            Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
