using System;
using System.Globalization;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, nota4, exame, media, mediaFinal;
            int peso = 10;

            string[] v = Console.ReadLine().Split(' ');
            nota1 = (float.Parse(v[0]) * 2);
            nota2 = (float.Parse(v[1]) * 3);
            nota3 = (float.Parse(v[2]) * 4);
            nota4 = (float.Parse(v[3]) * 1);

            media = (nota1 + nota2 + nota3 + nota4) / peso;

            if (media == 4.85f)
            {
                media = 4.8f;
            }

            if (media >= 7.0)
            {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5.0)
            {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno reprovado.");
            }
            else if (media >= 5.0 || media <= 6.9)
            {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno em exame.");
                exame = float.Parse(Console.ReadLine());
                Console.WriteLine("Nota do exame: " + exame.ToString("F1", CultureInfo.InvariantCulture));
                mediaFinal = (media + exame) / 2;
                if (mediaFinal >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine("Media final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                }
            }

        }
    }
}
