using System;
using System.Globalization;

namespace ExercicioFix02
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, notaFinal;

            nota1 = double.Parse(Console.ReadLine());
            nota2 = double.Parse(Console.ReadLine());

            notaFinal = nota1 + nota2;

            if (notaFinal >= 60.0)
            {
                Console.WriteLine("NOTA FINAL = " + notaFinal.ToString(("F1"), CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("NOTA FINAL = " + notaFinal.ToString(("F1"), CultureInfo.InvariantCulture));
                Console.WriteLine("REPROVADO");
            }
        }
    }
}