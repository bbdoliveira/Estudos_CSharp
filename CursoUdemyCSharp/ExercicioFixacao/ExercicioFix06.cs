using System;

namespace ExercicioFix02
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;

            string[] v = Console.ReadLine().Split(' ');

            x = int.Parse(v[0]);
            y = int.Parse(v[1]);
            z = int.Parse(v[2]);

            if (x < y && x < z)
            {
                Console.WriteLine("MENOR = " + x);
            }else if (y < z)
            {
                Console.WriteLine("MENOR = " + y);
            }else
            {
                Console.WriteLine("MENOR = " + z);
            }
        }
    }
}