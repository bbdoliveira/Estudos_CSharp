using System;
using System.Globalization;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159, raio, volume;

            raio = double.Parse(Console.ReadLine());

            volume = (4.0 / 3) * pi * Math.Pow(raio, 3.0);
            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
