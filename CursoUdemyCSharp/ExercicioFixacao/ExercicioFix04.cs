using System;
using System.Globalization;

namespace ExercicioFix04
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2;
            int idade1, idade2;
            double mediaIdade;
            string[] vet1, vet2;

            vet1 = Console.ReadLine().Split(' ');
            nome1 = vet1[0];
            idade1 = int.Parse(vet1[1]);

            vet2 = Console.ReadLine().Split(' ');
            nome2 = vet2[0];
            idade2 = int.Parse(vet2[1]);

            mediaIdade = (double)(idade1 + idade2) / 2.0; //Casting

            Console.WriteLine("A idade média de " + nome1 + " e " + nome2 + " é de " + mediaIdade.ToString("F1", CultureInfo.InvariantCulture) + " anos");
        }
    }
}