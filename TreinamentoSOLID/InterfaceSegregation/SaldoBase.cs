using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation
{
    public abstract class SaldoBase : ISaldo
    {
        public abstract void AtualizeSaldo();
    }
}
