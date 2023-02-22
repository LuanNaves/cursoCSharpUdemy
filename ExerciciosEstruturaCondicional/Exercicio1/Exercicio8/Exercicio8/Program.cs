using System;
using System.Globalization;

namespace Exercicio8 {
    class Program {
        static void Main(string[] args) {

            double imposto;
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario > 2000 && salario <= 3000) {
                imposto = (salario - 2000) * 0.08;
                Console.WriteLine($"R$ {imposto.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (salario > 3000 && salario <= 4500) {
                imposto = 1000 * 0.08 + (salario - 3000) * 0.18;
                Console.WriteLine($"R$ {imposto.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (salario > 4500) {
                imposto = 1500 * 0.18 + 1000 * 0.08 + (salario - 4500) * 0.28;
                Console.WriteLine($"R$ {imposto.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else {
                Console.WriteLine("Isento");
            }
        }
    }
}
