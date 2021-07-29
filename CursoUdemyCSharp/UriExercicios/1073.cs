using System;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, count;
            double par, resultado;

            count = 0;
            par = 2;
            resultado = 0;

            n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                for (int i = 0; count < n; i++)
                {
                    resultado = Math.Pow(par, 2.0);
                    count += 2;
                    Console.WriteLine(par + "^2" + " = " + resultado);
                    par += 2;
                }
            }
        }
    }
}
