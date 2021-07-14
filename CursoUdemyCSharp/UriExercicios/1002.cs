using System;
using System.Globalization;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            double area;
            double n = 3.14159;
            double raio;

            raio = double.Parse(Console.ReadLine());
            area = n * (Math.Pow(raio, 2.0));
            
            Console.WriteLine("A=" + area.ToString("F4",(CultureInfo.InvariantCulture)));
        }
    }
}