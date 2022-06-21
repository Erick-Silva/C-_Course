using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Csharp.Classes
{
    internal class ContaBancaria
    {
        //Properties

        public int NumeroConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }



        public ContaBancaria(int numeroConta, string nome)
        {
            NumeroConta = numeroConta;
            Titular = nome;
        }

        public ContaBancaria(int numeroConta, string nome, double saldo) : this(numeroConta, nome)
        {
            AdicionarSaldo(saldo);
        }

        public void AdicionarSaldo(double valor)
        {
            Saldo += valor;
        }

        public void SaqueSaldo(double valor)
        {
            Saldo -= valor + 5;
        }

        public override string ToString()
        {
            return "Conta "
                + NumeroConta
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
