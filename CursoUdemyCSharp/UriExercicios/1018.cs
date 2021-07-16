using System;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, cem, cinquenta, vinte, dez, cinco, dois, um, resto, valorLido;

            N = int.Parse(Console.ReadLine());
            valorLido = N;
            cem = N / 100;
            resto = N % 100;

            cinquenta = resto / 50;
            N = resto % 50;
            vinte = N / 20;
            resto = N % 20;
            dez = resto / 10;
            cinco = resto / 5;
            N = resto % 5;
            dois = N / 2;
            resto = N % 2;
            um = resto / 1;

            Console.WriteLine(valorLido);
            Console.WriteLine(cem + " nota(s) de R$ 100,00");
            Console.WriteLine(cinquenta + " nota(s) de R$ 50,00");
            Console.WriteLine(vinte + " nota(s) de R$ 20,00");
            Console.WriteLine(dez + " nota(s) de R$ 10,00");
            Console.WriteLine(cinco + " nota(s) de R$ 5,00");
            Console.WriteLine(dois + " nota(s) de R$ 2,00");
            Console.WriteLine(um + " nota(s) de R$ 1,00");
        }
    }
}
