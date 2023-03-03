using System;
using System.Globalization;

namespace Exercicio3 {
    class Program {
        static void Main(string[] args) {

            int casos = int.Parse(Console.ReadLine());
            double valor1, valor2, valor3, media;

            for (int i = 1; i <= casos; i++) {

                string[] valores = Console.ReadLine().Split();
                valor1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
                valor2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
                valor3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

                media = (valor1 * 2 + valor2 * 3 + valor3 * 5) / 10;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }

        }
    }
}
