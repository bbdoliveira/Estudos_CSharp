using System;
using System.Globalization;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, media;

            n1 = double.Parse(Console.ReadLine());
            while (n1 < 0.0 || n1 > 10.0)
            {
                Console.WriteLine("nota invalida");
                n1 = double.Parse(Console.ReadLine());
            }

            n2 = double.Parse(Console.ReadLine());
            while (n2 < 0.0 || n2 > 10.0)
            {
                Console.WriteLine("nota invalida");
                n2 = double.Parse(Console.ReadLine());
            }

            media = (n1 + n2) / 2;
            Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
