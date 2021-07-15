using System;
using System.Globalization;

namespace ExercicioFix01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Fazer um programa para executar a seguinte interação com o
            usuário, lendo os valores destacados em vermelho, e depois
            mostrar os dados na tela:
            Entre com seu nome completo:  Alex Green
            Quantos quartos tem na sua casa?  3
            Entre com o preço de um produto:  500.50
            Entre seu último nome, idade e altura (mesma linha):
            Green 21 1.73
            */
            string nomeCompleto, ultimoNome;
            int quartos, idade;
            double preco, altura;

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("Entre com seu nome completo: ");
            nomeCompleto = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha): ");
            string[] v = Console.ReadLine().Split(' ');
            ultimoNome = v[0];
            idade = int.Parse(v[1]);
            altura = double.Parse(v[2]);

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("Seu nome é: " + nomeCompleto);
            Console.WriteLine("A sua casa tem " + quartos + " quartos!");
            Console.WriteLine("O preço do seu produto é: " + preco.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine("Seu último nome é: " + ultimoNome + ", sua idade é: " + idade + " e você tem: " + altura.ToString(CultureInfo.InvariantCulture) + " de altura.");

        }
    }
}