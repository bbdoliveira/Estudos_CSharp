using System;
using System.Globalization;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, maior1, maior2;

            string[] v = Console.ReadLine().Split(' ');
            a = int.Parse(v[0]);
            b = int.Parse(v[1]);
            c = int.Parse(v[2]);

            maior1 = (a + b + Math.Abs(a - b)) / 2;
            maior2 = (maior1 + c + Math.Abs(maior1 - c)) / 2;

            Console.WriteLine(maior2 + " eh o maior");
        }
    }
}
