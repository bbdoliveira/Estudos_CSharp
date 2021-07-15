using System;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            int distancia, kmPorMin = 2, tempo;

            distancia = int.Parse(Console.ReadLine());
            tempo = distancia * kmPorMin;
            Console.WriteLine(tempo + " minutos");


        }
    }
}
