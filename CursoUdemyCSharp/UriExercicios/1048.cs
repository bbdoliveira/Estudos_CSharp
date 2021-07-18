using System;
using System.Globalization;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, salarioFinal, valorAumento, porcentagem15, porcentagem12, porcentagem10, porcentagem7, porcentagem4;

            salario = double.Parse(Console.ReadLine());
            porcentagem15 = salario * 15 / 100;
            porcentagem12 = salario * 12 / 100;
            porcentagem10 = salario * 10 / 100;
            porcentagem7 = salario * 7 / 100;
            porcentagem4 = salario * 4 / 100;

            if (salario <= 400.00)
            {
                salarioFinal = salario + porcentagem15;
                valorAumento = salarioFinal - salario;
                Console.WriteLine("Novo salario: " + salarioFinal.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + valorAumento.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 15 %");
            }
            else if (salario > 400.00 && salario <= 800.00)
            {
                salarioFinal = salario + porcentagem12;
                valorAumento = salarioFinal - salario;
                Console.WriteLine("Novo salario: " + salarioFinal.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + valorAumento.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 12 %");
            }
            else if (salario > 800.00 && salario <= 1200.00)
            {
                salarioFinal = salario + porcentagem10;
                valorAumento = salarioFinal - salario;
                Console.WriteLine("Novo salario: " + salarioFinal.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + valorAumento.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 10 %");
            }
            else if (salario > 1200.00 && salario <= 2000.00)
            {
                salarioFinal = salario + porcentagem7;
                valorAumento = salarioFinal - salario;
                Console.WriteLine("Novo salario: " + salarioFinal.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + valorAumento.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 7 %");
            }
            else
            {
                salarioFinal = salario + porcentagem4;
                valorAumento = salarioFinal - salario;
                Console.WriteLine("Novo salario: " + salarioFinal.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + valorAumento.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 4 %");
            }
        }
    }
}
