using System;

namespace Exercicio5 {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            int fatorial = 1;

            for (int i = 1; i <= n; i++) {
                fatorial = fatorial * i;
            }

            Console.WriteLine(fatorial);
        }
    }
}