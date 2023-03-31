using System.Globalization;

namespace Exercicio1 {
    internal class ContaBancaria {
        public int Id { get; private set; }
        public double Saldo { get; private set; }
        public string Titular;

        public ContaBancaria(int id, string titular) {
            Id = id;
            Titular = titular;
            Saldo = 0;
        }
         
        public ContaBancaria(int id, string titular, double depositoInicial) : this(id, titular) {
            Depositar(depositoInicial);

        }

        public void Depositar(double valor) {
            Saldo += valor;
        }

        public void Sacar(double valor) {
            Saldo -= valor + 5;
        }

        public override string ToString() {
            return "Conta " + Id + ", Titular: " + Titular + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
