using System;
using System.Globalization;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, media;
            double pesos = 11;

            a = (double.Parse(Console.ReadLine()) * 3.5);
            b = (double.Parse(Console.ReadLine()) * 7.5);
            media = (a + b) / pesos;
            Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));
        }
    }
}
