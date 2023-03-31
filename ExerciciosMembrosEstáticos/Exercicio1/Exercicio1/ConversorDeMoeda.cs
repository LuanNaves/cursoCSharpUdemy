namespace Exercicio1 {
    internal class ConversorDeMoeda {

        public static double Cotação, Valor;
        public static double ValorConvertido() {
            return (Valor * 0.06 + Valor) * Cotação;
        }
    }
}
