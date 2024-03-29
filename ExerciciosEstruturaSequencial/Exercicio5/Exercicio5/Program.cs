﻿using System;
using System.Globalization;

namespace Exercicio5 {
    class Program {
        static void Main(string[] args) {

            int cod1, cod2, quant1, quant2;
            double preco1, preco2, total;

            string[] valores = Console.ReadLine().Split();
            cod1 = int.Parse(valores[0]);
            quant1 = int.Parse(valores[1]);
            preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split();
            cod2 = int.Parse(valores[0]);
            quant2 = int.Parse(valores[1]);
            preco2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            total = quant1 * preco1 + quant2 * preco2;

            Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}