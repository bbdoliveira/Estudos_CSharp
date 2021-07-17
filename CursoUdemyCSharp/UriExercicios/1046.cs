using System;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInicial, horaFinal, duracao, duracaoDia;

            duracaoDia = 24;

            string[] v = Console.ReadLine().Split(' ');
            horaInicial = int.Parse(v[0]);
            horaFinal = int.Parse(v[1]);

            if (horaInicial > horaFinal || horaInicial == horaFinal)
            {
                duracao = (duracaoDia - horaInicial) + horaFinal;
                Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
            }
            else
            {
                duracao = horaFinal - horaInicial;
                Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
            }
        }
    }
}
