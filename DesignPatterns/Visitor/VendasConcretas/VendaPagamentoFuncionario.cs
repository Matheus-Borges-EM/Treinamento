using System;

namespace Visitor
{
    public class VendaPagamentoFuncionario : IVenda
    { 
        public void AceiteVisitor(IVisitor visitor)
        {
            visitor.Visite(this);
        }
    }
}