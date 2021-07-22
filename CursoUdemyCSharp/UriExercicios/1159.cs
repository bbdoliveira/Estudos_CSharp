using System;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, soma = 0, count = 0;

            x = int.Parse(Console.ReadLine());

            while (x != 0)
            {
                if (x % 2 == 0)
                {
                    while (count <= 4)
                    {
                        soma += x;
                        x += 2;
                        count++;
                    }
                    Console.WriteLine(soma);
                }
                else
                {
                    x += 1;
                    while (count <= 4)
                    {
                        soma += x;
                        x += 2;
                        count++;
                    }
                    Console.WriteLine(soma);
                }
                x = int.Parse(Console.ReadLine());
                soma = 0;
                count = 0;
            }
        }
    }
}
