using System;

namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase, x, y, z;
            
            frase = Console.ReadLine();
            x = Console.ReadLine();
            y = Console.ReadLine();
            z = Console.ReadLine();

            string[] v = Console.ReadLine().Split(' ');//Separa utilizando como critério o que tem dentro das ''.
            string a = v[0];
            string b = v[1];
            string c = v[2];

            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.Write(a + " " + b + " " + c);

        }
    }
}