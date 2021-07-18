using System;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, apoio;

            string[] v = Console.ReadLine().Split(' ');
            a = double.Parse(v[0]);
            b = double.Parse(v[1]);
            c = double.Parse(v[2]);

            if (a < b)
            {
                apoio = a;
                a = b;
                b = apoio;
            }
            if (a < c)
            {
                apoio = a;
                a = c;
                c = apoio;
            }
            if (b < c)
            {
                apoio = b;
                b = c;
                c = apoio;
            }

            if (a >= (b + c))
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else
            {
                if (Math.Pow(a, 2.0) == (Math.Pow(b, 2.0) + Math.Pow(c, 2.0)))
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                } 
                else if (Math.Pow(a, 2.0) > (Math.Pow(b, 2.0) + Math.Pow(c, 2.0)))
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                } 
                else
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }
                
                if (a == b && b == c)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
        }
    }
}
