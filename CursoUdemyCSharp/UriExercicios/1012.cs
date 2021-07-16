using System;
using System.Globalization;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, areaTriangulo, areaTrapezio, areaCirculo, areaQuadrado, areaRetangulo, pi;
            pi = 3.14159;

            string[] v = Console.ReadLine().Split(' ');
            a = double.Parse(v[0]);
            b = double.Parse(v[1]);
            c = double.Parse(v[2]);

            //Area do Triângulo = base * altura / 2
            areaTriangulo = (a * c) / 2;

            //Area do Circulo = Pi * raio²
            areaCirculo = pi * Math.Pow(c, 2.0);

            //Area do Trapézio = (base maior + menor) * altura / 2
            areaTrapezio = (a + b) * c / 2;

            //Area do Quadrado = base * altura (como todos os lados são iguais é so elever ao quadrado)
            areaQuadrado = Math.Pow(b, 2.0);

            //Area do Retangulo = base * altura
            areaRetangulo = a * b;

            Console.WriteLine("TRIANGULO: " + areaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
