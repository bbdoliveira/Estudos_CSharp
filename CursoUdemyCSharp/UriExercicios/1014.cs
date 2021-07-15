using System;
using System.Globalization;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            double y, consumoMedio;

            x = int.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());

            consumoMedio = x / y;

            Console.WriteLine((consumoMedio.ToString("F3", CultureInfo.InvariantCulture)) + " km/l");

        }
    }
}
