using System;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, count = 1;

            n = int.Parse(Console.ReadLine());

            
            for (int i = 0; count <= 10000; i++)
            {
                if (count % n == 2)
                {
                    Console.WriteLine(count);
                    count++;
                }
                count++;
            }
        }
    }
}
