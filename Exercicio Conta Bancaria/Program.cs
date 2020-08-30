using System;
using System.Globalization;

namespace Exercicio_Conta_Bancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeroconta;
            string titular;
            string depositoinicial;
            double valordepositoinicial = 0.00;
            double deposito;
            double saque;

            Console.Write("Entre com o número da conta: ");
            numeroconta = Console.ReadLine();
            Console.Write("Entre com o titular da conta: ");
            titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            depositoinicial = Console.ReadLine();
            if (depositoinicial == "s" || depositoinicial == "S")
            {
                Console.Write("Entre com o valor de depósito inicial: ");
                valordepositoinicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }


            Conta conta = new Conta(numeroconta, titular, valordepositoinicial);

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);
            Console.Write("");

            Console.Write("Entre com o valor para depósito: ");
            deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(deposito);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
            Console.Write("");


            Console.Write("Entre com o valor para saque: ");
            saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
            Console.Write("");



        }
    }
}
