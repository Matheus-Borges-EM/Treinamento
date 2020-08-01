using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.VisitorsConcretos 
{
    public class VisitorConcreto : IVisitor
    {
        public void Visite(VendaMatricula vendaMatricula)
        {
            Console.WriteLine("Calculado o desconto da mensalidade");
        }

        public void Visite(VendaMaterial vendaMaterial)
        {
            Console.WriteLine("Registre quantidade de material compro");
        }

        public void Visite(VendaPagamentoFuncionario vendaPagamentoFuncionario)
        {
            Console.WriteLine("Desconte valor do FGTS");
        }
    }
}
