using System;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, ini;

            x = int.Parse(Console.ReadLine());
            ini = 1;

            if (x % 2 == 0)
            {
                for (int i = 0; ini < x; i++)
                {
                    Console.WriteLine(ini);
                    ini += 2;
                }
            }
            else
            {
                for (int i = 0; ini < x; i++)
                {
                    Console.WriteLine(ini);
                    ini += 2;
                }
                Console.WriteLine(x);
            }
        }
    }
}
