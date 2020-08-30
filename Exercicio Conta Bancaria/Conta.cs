using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Exercicio_Conta_Bancaria
{
    class Conta
    {
        public string _conta { get; private set; }
        public string _titular { get; set; }
        public double _saldo { get; private set; }

        public Conta(string conta, string titular, double deposito)
        {
            _conta = conta;
            _titular = titular;
            _saldo = deposito;
        }

        public override string ToString()
        {
            return "Conta " + _conta + ", Titular: " + _titular + ", Saldo: $ " + _saldo.ToString("F2");
        }

        public void Deposito(double deposito)
        {
            _saldo += deposito;
        }

        public void Saque(double saque)
        {
            _saldo = _saldo - saque - 5.00;
        }
    }
}
