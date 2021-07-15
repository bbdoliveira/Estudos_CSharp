using System;
using System.Globalization;

namespace EntradaDeDados2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, idade;
            string nome;
            double n2 = 0.0;
            double altura = 0.0;
            char sexo, ch;

            n1 = int.Parse(Console.ReadLine());
            ch = char.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());

            string[] v = Console.ReadLine().Split(' ');
            nome = v[0];
            sexo = char.Parse(v[1]);
            idade = int.Parse(v[2]);
            altura = double.Parse(v[3]);

            Console.WriteLine("+-------------------------+");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine(nome + " " + sexo + " " + idade + " " + altura.ToString(CultureInfo.InvariantCulture));

        }
    }
}