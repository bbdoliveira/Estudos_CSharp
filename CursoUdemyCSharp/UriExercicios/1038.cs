using System;
using System.Globalization;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            double preco, precoFinal;

            String[] vet = Console.ReadLine().Split(' ');
            codigo = int.Parse(vet[0]);
            quantidade = int.Parse(vet[1]);

            switch (codigo)
            {
                case 1:
                    preco = 4.00;
                    precoFinal = preco * quantidade;
                    Console.WriteLine("Total: R$ " + precoFinal.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 2:
                    preco = 4.50;
                    precoFinal = preco * quantidade;
                    Console.WriteLine("Total: R$ " + precoFinal.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 3:
                    preco = 5.00;
                    precoFinal = preco * quantidade;
                    Console.WriteLine("Total: R$ " + precoFinal.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 4:
                    preco = 2.00;
                    precoFinal = preco * quantidade;
                    Console.WriteLine("Total: R$ " + precoFinal.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 5:
                    preco = 1.50;
                    precoFinal = preco * quantidade;
                    Console.WriteLine("Total: R$ " + precoFinal.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                default:
                    Console.WriteLine("Não temos este item!");
                    break;
            }
            
        }
    }
}
