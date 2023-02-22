using System;
using System.Globalization;

namespace Exercicio5 {
    class Program {
        static void Main(string[] args) {

            string[] valores = Console.ReadLine().Split();

            int item = int.Parse(valores[0]);
            int quant = int.Parse(valores[1]);
            double preço, total;

            if (item == 1) {
                preço = 4.00;
            }
            else if (item == 2) {
                preço = 4.50;
            }
            else if (item == 3) {
                preço = 5.00;
            }
            else if (item == 4) {
                preço = 2.00;
            }
            else {
                preço = 1.50;
            }

            total = preço * quant;
            Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}