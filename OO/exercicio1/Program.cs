using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Tsukabank");

           ContaCorrente conta1 = new ContaCorrente();

            Console.WriteLine("Digite o nome do titular");
            conta1.titular = Console.ReadLine();
            
            Console.WriteLine("Número da agência: ");
            conta1.agencia = int.Parse(Console.ReadLine());

            Console.WriteLine("Número da conta: ");
            conta1.numeroConta = int.Parse(Console.ReadLine());

            conta1.Depositar(1000);

            Console.WriteLine("Quando você deseja sacar?: ");
            double valor = double.Parse(Console.ReadLine());
            // bool resultado = conta1.Sacar(valor);


            Console.WriteLine($"---------------------");
            Console.WriteLine($"Titular: {conta1.titular}");
            Console.WriteLine($"Agência: {conta1.agencia}");
            Console.WriteLine($"Número da conta: {conta1.numeroConta}");
            Console.WriteLine($"Saldo: {conta1.saldo}");
            Console.WriteLine($"---------------------");


            ContaCorrente conta2 = new ContaCorrente();
            Console.WriteLine("Digite o nome do titular");
            conta2.titular = Console.ReadLine();
            
            Console.WriteLine("Número da agência: ");
            conta2.agencia = int.Parse(Console.ReadLine());

            Console.WriteLine("Número da conta: ");
            conta2.numeroConta = int.Parse(Console.ReadLine());

            conta2.Depositar(3000);

            Console.WriteLine("Quando você deseja sacar?: ");
            double valor2 = double.Parse(Console.ReadLine());
            // bool resultado2 = conta1.Sacar(valor2);
            Console.WriteLine($"---------------------");
            Console.WriteLine($"Titular: {conta1.titular}");
            Console.WriteLine($"Agência: {conta1.agencia}");
            Console.WriteLine($"Número da conta: {conta1.numeroConta}");
            Console.WriteLine($"Saldo: {conta1.saldo}");
            Console.WriteLine($"---------------------");

            Console.WriteLine($"---------------------");
            Console.WriteLine($"Titular: {conta2.titular}");
            Console.WriteLine($"Agência: {conta2.agencia}");
            Console.WriteLine($"Numero da conta: {conta2.numeroConta}");
            Console.WriteLine($"Saldo: {conta2.saldo}");
            Console.WriteLine($"---------------------");

            bool resultadoTransferencia = true;
            
            do{

            

            Console.WriteLine("Quando deseja transferir da conta1 para a conta2? ");
            double valorTransferencia = double.Parse(Console.ReadLine());
            resultadoTransferencia = conta1.Transferir (valorTransferencia, conta2);
            }while(resultadoTransferencia != true);


            Console.WriteLine ($"--------------Resultado Após Transfêrencia---------------");
            Console.WriteLine ($"Saldo conta1: {conta1.saldo}");
            Console.WriteLine ($"Saldo conta2: {conta2.saldo}");



        }
    }
}
