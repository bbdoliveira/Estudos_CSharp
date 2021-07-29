using System;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, caso, dentro, fora;

            caso = 0;
            dentro = 0;
            fora = 0;

            x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                caso = int.Parse(Console.ReadLine());
                if (caso >= 10 && caso <= 20)
                {
                    dentro += 1;
                }
                else
                {
                    fora += 1;
                }
            }
            Console.WriteLine(dentro + "in");
            Console.WriteLine(fora + "out");
        }
    }
}
