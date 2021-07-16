using System;
using System.Globalization;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, distancia;

            string[] v = Console.ReadLine().Split(' ');
            x1 = double.Parse(v[0]);
            y1 = double.Parse(v[1]);

            string[] v2 = Console.ReadLine().Split(' ');
            x2 = double.Parse(v2[0]);
            y2 = double.Parse(v2[1]);

            distancia = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0));

            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
