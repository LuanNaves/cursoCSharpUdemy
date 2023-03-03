using System;

namespace Exercicio7 {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());
            int quad, cubo;

            for (int i = 1; i <= n; i++) {
                quad = (int)Math.Pow(i, 2);
                cubo = (int)Math.Pow(i, 3);

                Console.WriteLine($"{i} {quad} {cubo}");
            }
        }
    }
}
