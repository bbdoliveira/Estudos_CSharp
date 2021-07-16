using System;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, ano, mes, dia, resto;

            N = int.Parse(Console.ReadLine());

            ano = N / 365;
            resto = N % 365;
            mes = resto / 30;
            dia = resto % 30;

            Console.WriteLine(ano + " ano(s)");
            Console.WriteLine(mes + " mes(es)");
            Console.WriteLine(dia + " dia(s)");
        }
    }
}
