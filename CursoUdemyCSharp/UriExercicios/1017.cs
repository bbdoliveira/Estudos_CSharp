using System;
using System.Globalization;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempo, distancia;
            double combustivel, distanciaPorLitro = 12;

            tempo = int.Parse(Console.ReadLine());
            distancia = int.Parse(Console.ReadLine());

            combustivel = (tempo * distancia) / distanciaPorLitro;
            Console.WriteLine(combustivel.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
