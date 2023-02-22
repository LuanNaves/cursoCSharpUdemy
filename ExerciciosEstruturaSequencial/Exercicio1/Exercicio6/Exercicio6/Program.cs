using System;
using System.Globalization;

namespace Exercicio6 {
    class Program {
        static void Main(string[] args) {
            double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo, pi;

            string[] valores = Console.ReadLine().Split();
            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);
            
            pi = 3.14159;

            triangulo = (A * C) / 2;
            circulo = Math.Pow(C, 2) * pi;
            trapezio = (A + B) * C / 2;
            quadrado = Math.Pow(B, 2);
            retangulo = A * B;

            Console.WriteLine($"TRIANGULO: {triangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO: {circulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {quadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO: {retangulo.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}