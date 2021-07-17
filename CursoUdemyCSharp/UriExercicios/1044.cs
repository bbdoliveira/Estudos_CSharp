using System;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            string[] vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);


            if (a % b ==0 || b % a == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
