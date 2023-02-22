using System;

namespace Exercicio3 {
    class Program {
        static void Main(string[] args) {
            int codigo = int.Parse(Console.ReadLine());
            int alcool = 0, gasolina = 0, diesel = 0;

            while (codigo != 4) {
                if (codigo == 1) {
                    alcool += 1;
                }
                else if (codigo == 2) {
                    gasolina += 1;
                }
                else if (codigo == 3) {
                    diesel += 1;
                }

                codigo = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
        }
    }
}
