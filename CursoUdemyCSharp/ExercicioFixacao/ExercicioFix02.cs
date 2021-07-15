using System;
using System.Globalization;

namespace ExercicioFix02
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura;
            double comprimento;
            double precoMetro;
            double area, precoFinal;
            
            Console.WriteLine("Digite por favor os dados do terreno.");
            Console.Write("Largura: ");
            largura = double.Parse(Console.ReadLine());
            Console.Write("Comprimento: ");
            comprimento = double.Parse(Console.ReadLine());
            Console.Write("Preço M²: ");
            precoMetro = double.Parse(Console.ReadLine());

            area = largura * comprimento;
            precoFinal = area * precoMetro;

            Console.WriteLine("+-------------------------");
            Console.WriteLine("O seu terreno tem: " + area.ToString("F2", CultureInfo.InvariantCulture) + " metros de área!");
            Console.WriteLine("Ao preço de: " + precoFinal.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Obrigado!");
            
        }
    }
}