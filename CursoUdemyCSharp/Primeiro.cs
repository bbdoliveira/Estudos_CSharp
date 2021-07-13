using System;
using System.Globalization;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ola Mundo");

            double x = 10.35784;

            Console.Write("Número completo: ");
            Console.WriteLine(x); //Imprime o número completo
            Console.Write("Número com 2 casas decimais: ");
            Console.WriteLine(x.ToString("F2")); //Imprime o número com 2 casas decimais
            Console.Write("Número com 4 casas decimais: ");
            Console.WriteLine(x.ToString("F4")); //Imprime o número com 4 casas decimais
            Console.Write("Número sem o tipo de moeda local: ");
            //Para usar o CultureInfo.InvariantCulture é preciso importar o (System.Globalization;).
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));


            Console.ReadLine();
        }
    }
}