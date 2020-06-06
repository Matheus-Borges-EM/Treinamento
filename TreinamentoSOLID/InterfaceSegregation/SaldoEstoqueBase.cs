using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation
{
    public abstract class SaldoEstoqueBase : SaldoBase, ISaldoEstoque
    {
        public override void AtualizeSaldo()
        {
            Console.WriteLine("Saldo de estoque atualizado.");
        }
    }
}
