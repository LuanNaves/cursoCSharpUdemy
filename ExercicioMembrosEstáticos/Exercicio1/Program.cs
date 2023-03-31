using System;
using System.Globalization;

namespace Exercicio1 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Qual é a cotação do dólar? ");
            ConversorDeMoeda.Cotação = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            ConversorDeMoeda.Valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write($"Valor a ser pago em reais = {ConversorDeMoeda.ValorConvertido().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
