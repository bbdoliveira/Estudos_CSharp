using System;
using System.Globalization;

namespace Exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, menos10 = 0, entre10e20 = 0, maior20 = 0;
            double lucro = 0, lucroTotal = 0.0, totalCompra = 0.0, totalVenda = 0.0;

            N = int.Parse(Console.ReadLine());

            string[] mercadoria = new string[N];
            double[] precoCompra = new double[N];
            double[] precoVenda = new double[N];

            for (int i = 0; i < N; i++)
            {
                string[] v = Console.ReadLine().Split(' ');
                mercadoria[i] = v[0];
                precoCompra[i] = double.Parse(v[1]);
                precoVenda[i] = double.Parse(v[2]);
                totalCompra += precoCompra[i];
                totalVenda += precoVenda[i];
            }

            lucroTotal = totalVenda - totalCompra;

            for (int i = 0; i < N; i++)
            {
                lucro = (precoVenda[i] - precoCompra[i]) * 100 / precoCompra[i];
                if (lucro < 10)
                {
                    menos10++;
                }
                else if (lucro >= 10 && lucro <= 20)
                {
                    entre10e20++;
                }
                else
                {
                    maior20++;
                }
            }

            Console.WriteLine("Lucro abaixo de 10%: " + menos10);
            Console.WriteLine("Lucro entre 10% e 20%: " + entre10e20);
            Console.WriteLine("Lucro acima de 20%: " + maior20);
            Console.WriteLine("Valor total de compra: " + totalCompra.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total de venda: " + totalVenda.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lucro total: " + lucroTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}