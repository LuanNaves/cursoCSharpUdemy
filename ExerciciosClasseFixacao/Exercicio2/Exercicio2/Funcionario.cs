using System;
using System.Globalization;
namespace Exercicio2 {
    internal class Funcionario {
        public string Nome;
        public double SalarioBruto, Imposto;

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem) {
            SalarioBruto += porcentagem / 100 * SalarioBruto;
        }

        public override string ToString() {
            return Nome + ", R$" + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
