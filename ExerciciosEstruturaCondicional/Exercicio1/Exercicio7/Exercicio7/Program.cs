using System;
using System.Globalization;

namespace Exercicio7 {
    class Program {
        static void Main(string[] args) {

            string[] coordenadas = Console.ReadLine().Split();

            double x = double.Parse(coordenadas[0], CultureInfo.InvariantCulture);
            double y = double.Parse(coordenadas[1],CultureInfo.InvariantCulture);

            if (x == 0 && y != 0) {
                Console.WriteLine("Eixo Y");
            }
            else if (x != 0 && y == 0) {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0 && y > 0) {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0) {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0) {
                Console.WriteLine("Q3");
            }
            else if (x > 0 && y < 0) {
                Console.WriteLine("Q4");
            }
            else {
                Console.WriteLine("Origem");
            }
        }
    }
}