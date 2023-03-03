using System;
using System.Globalization;

namespace Exercicio4 {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());
            int numerador, denominador;

            for (int i = 1; i <= n; i++) {

                string[] valores = Console.ReadLine().Split();
                numerador = int.Parse(valores[0]);
                denominador = int.Parse(valores[1]);

                if (denominador == 0) {
                    Console.WriteLine("divisao impossivel");
                }
                else {
                    double divisao = (double)numerador / denominador;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
