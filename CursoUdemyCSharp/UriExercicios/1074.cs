using System;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, valor;

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                valor = int.Parse(Console.ReadLine());

                if (valor % 2 == 0 && valor > 0)
                {
                    Console.WriteLine("EVEN POSITIVE");
                }
                else if (valor % 2 == 0 && valor < 0)
                {
                    Console.WriteLine("EVEN NEGATIVE");
                }
                else if (valor == 0)
                {
                    Console.WriteLine("NULL");
                }
                else if (valor > 0)
                {
                    Console.WriteLine("ODD POSITIVE");
                }
                else
                {
                    Console.WriteLine("ODD NEGATIVE");
                }
            }
        }
    }
}
