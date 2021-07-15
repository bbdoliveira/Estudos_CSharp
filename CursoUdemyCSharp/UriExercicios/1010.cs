using System;
using System.Globalization;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigoPeca, quantidade1, quantidade2;
            double valor1, valor2, precoFinal;

            string[] vet = Console.ReadLine().Split(' ');
            codigoPeca = int.Parse(vet[0]);
            quantidade1 = int.Parse(vet[1]);
            valor1 = double.Parse(vet[2]);
            
            string[] vet2 = Console.ReadLine().Split(' ');
            codigoPeca = int.Parse(vet2[0]);
            quantidade2 = int.Parse(vet2[1]);
            valor2 = double.Parse(vet2[2]);

            precoFinal = (valor1 * quantidade1) + (valor2 * quantidade2);
            Console.WriteLine("VALOR A PAGAR: R$ " + precoFinal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
