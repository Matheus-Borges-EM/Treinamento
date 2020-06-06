using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation
{
    public abstract class SaldoFinanceiroBase : SaldoBase, ISaldoFinanceiro
    {
        public override void AtualizeSaldo()
        {
            Console.WriteLine("O saldo financeiro foi atualizado.");
        }
    }
}
