using System;
using Visitor.VisitorsConcretos;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var vendaMatricula = new VendaMatricula();
            var vendaMaterial = new VendaMaterial();
            var vendaPagamentoFuncionario = new VendaPagamentoFuncionario();

            var visitor = new VisitorConcreto();

            vendaMaterial.AceiteVisitor(visitor);
            vendaPagamentoFuncionario.AceiteVisitor(visitor);
            vendaMatricula.AceiteVisitor(visitor);

            Console.ReadKey();
        }
    }
}
