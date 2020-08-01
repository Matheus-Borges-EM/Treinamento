using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public interface IVisitor
    {
        public void Visite(VendaMatricula vendaMatricula);

        public void Visite(VendaMaterial vendaMaterial);
        
        public void Visite(VendaPagamentoFuncionario vendaPagamentoFuncionario);        
    }
}
