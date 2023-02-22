using System;
using System.Globalization;

namespace Exercicio4 {
    class Program {
        static void Main(string[] args) {

            int funcionario = int.Parse(Console.ReadLine());
            int horas = int.Parse(Console.ReadLine());
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salario = horas * valorHora;

            Console.WriteLine($"NUMBER = {funcionario}");
            Console.WriteLine($"SALARY = U${salario.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}