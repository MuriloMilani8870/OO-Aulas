namespace exercicio1 {
    public class ContaCorrente {
        public string titular;

        public int agencia;

        public int numeroConta;

        public double saldo { get; private set; }

        public void Depositar (double valor) {
            saldo += valor;

        }

        public bool Sacar (double valor) {

            if (saldo < valor) {
                return false;

            } else {
                saldo -= valor;
                return true;
            }

        }

        public bool Transferir (double valor, ContaCorrente contaDestino) {

            if (valor > saldo) {
                return false;
            } else {
                saldo -= valor;
                contaDestino.saldo += valor;
                return true;
            }

        }
    }
}