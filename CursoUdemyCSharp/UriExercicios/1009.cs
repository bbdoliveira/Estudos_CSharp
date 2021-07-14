using System;
using System.Globalization;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeVendedor;
            double salario, comissao, vendas, salarioFinal;

            nomeVendedor = Console.ReadLine();
            salario = double.Parse(Console.ReadLine());
            vendas = double.Parse(Console.ReadLine());

            comissao = (vendas * 15) / 100;
            salarioFinal = salario + comissao;

            Console.WriteLine("TOTAL = R$ " + salarioFinal.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
